using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Student_Performance.Model
{
    class Tree
    {
        public Node Root { get; set; }

        public static string CalculateResult(Node root, IDictionary<string, string> valuesForQuery, string result)
        {
            var valueFound = false;

            result += root.Name.ToUpper() + " -- ";

            if (root.IsLeaf)
            {
                result = root.Edge.ToLower() + " --> " + root.Name.ToUpper();
                valueFound = true;
            }
            else
            {
                foreach (var childNode in root.ChildNodes)
                {
                    foreach (var entry in valuesForQuery)
                    {
                        if (childNode.Edge.ToUpper().Equals(entry.Value.ToUpper()) && root.Name.ToUpper().Equals(entry.Key.ToUpper()))
                        {
                            valuesForQuery.Remove(entry.Key);

                            return result + CalculateResult(childNode, valuesForQuery, $"{childNode.Edge.ToLower()} --> ");
                        }
                    }
                }
            }
            // Si el usuario ingres aun atributo invalido
            if (!valueFound)
            {
                result = "Attribute not found";
            }

            return result;
        }

        public static Node Learn(DataTable data, string edgeName)
        {
            var root = GetRootNode(data, edgeName);

            foreach (var item in root.NodeAttribute.DifferentAttributeNames)
            {
                //Si el nodo es hoja, se agrega al metodo
                var isLeaf = CheckIfIsLeaf(root, data, item);

                //Hacer un llamado recursivo si el nodo no es una hoja
                if (!isLeaf)
                {
                    var reducedTable = CreateSmallerTable(data, item, root.TableIndex);

                    root.ChildNodes.Add(Learn(reducedTable, item));
                }
            }
            return root;
        }

        private static bool CheckIfIsLeaf(Node root, DataTable data, string attributeToCheck)
        {
            var isLeaf = true;
            var allEndValues = new List<string>();

            // Obtener todos los valores de la hoja para el atributo en cuestion
            for (var i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][root.TableIndex].ToString().Equals(attributeToCheck))
                {
                    allEndValues.Add(data.Rows[i][data.Columns.Count - 1].ToString());
                }
            }
            // Comprobar si todos los elementos de la lista tienen el mismo valor
            if (allEndValues.Count > 0 && allEndValues.Any(x => x != allEndValues[0]))
            {
                isLeaf = false;
            }
            //Crear una hoja con alor para mostrar y edge a la hoja
            if (isLeaf)
            {
                root.ChildNodes.Add(new Node(true, allEndValues[0], attributeToCheck));
            }
            return isLeaf;
        }

        private static DataTable CreateSmallerTable(DataTable data, string edgePointingToNextNode, int rootTableIndex)
        {
            var smallerData = new DataTable();

            //Agregar los titulos de las columnas
            for (var i = 0; i < data.Columns.Count; i++)
            {
                smallerData.Columns.Add(data.Columns[i].ToString());
            }
            //Agregar filas que contienen edgePointingToNextNode a la nueva tabla de datos
            for (var i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][rootTableIndex].ToString().Equals(edgePointingToNextNode))
                {
                    var row = new string[data.Columns.Count];

                    for (var j = 0; j < data.Columns.Count; j++)
                    {
                        row[j] = data.Rows[i][j].ToString();
                    }

                    smallerData.Rows.Add(row);
                }
            }
            //Remover la columna que ha sido usada como nodo          
            smallerData.Columns.Remove(smallerData.Columns[rootTableIndex]);

            return smallerData;
        }

        private static Node GetRootNode(DataTable data, string edge)
        {
            var attributes = new List<Attribute>();
            var highestInformationGainIndex = -1;
            var highestInformationGain = double.MinValue;

            // Obtener todos los nombres, cantidad de atributos y atributos para cada columna            
            for (var i = 1; i < data.Columns.Count; i++)
            {
                var differentAttributenames = Attribute.GetDifferentAttributeNamesOfColumn(data, i - 1);
                attributes.Add(new Attribute(data.Columns[i - 1].ToString(), differentAttributenames));
            }

            //Calculo de la entropia
            var tableEntropy = CalculateTableEntropy(data);

            for (var i = 0; i < attributes.Count; i++)
            {
                attributes[i].InformationGain = GetGainForAllAttributes(data, i, tableEntropy);

                if (attributes[i].InformationGain > highestInformationGain)
                {
                    highestInformationGain = attributes[i].InformationGain;
                    highestInformationGainIndex = i;
                }
            }

            return new Node(attributes[highestInformationGainIndex].Name, highestInformationGainIndex, attributes[highestInformationGainIndex], edge);
        }

        private static double GetGainForAllAttributes(DataTable data, int colIndex, double entropyOfDataset)
        {
            var totalRows = data.Rows.Count;
            var amountForDifferentValue = GetAmountOfEdgesAndTotalPositivResults(data, colIndex);
            var stepsForCalculation = new List<double>();

            foreach (var item in amountForDifferentValue)
            {
                // Ayudas para el calculo
                var firstDivision = item[0, 1] / (double)item[0, 0];
                var secondDivision = (item[0, 0] - item[0, 1]) / (double)item[0, 0];

                // Prevenir la excepcion de division entre 0
                if (firstDivision == 0 || secondDivision == 0)
                {
                    stepsForCalculation.Add(0.0);
                }
                else
                {
                    stepsForCalculation.Add(-firstDivision * Math.Log(firstDivision, 2) - secondDivision * Math.Log(secondDivision, 2));
                }
            }
            var gain = stepsForCalculation.Select((t, i) => amountForDifferentValue[i][0, 0] / (double)totalRows * t).Sum();

            gain = entropyOfDataset - gain;

            return gain;
        }

        private static double CalculateTableEntropy(DataTable data)
        {
            var totalRows = data.Rows.Count;
            var amountForDifferentValue = GetAmountOfEdgesAndTotalPositivResults(data, data.Columns.Count - 1);

            var stepsForCalculation = amountForDifferentValue
                .Select(item => item[0, 0] / (double)totalRows)
                .Select(division => -division * Math.Log(division, 2))
                .ToList();

            return stepsForCalculation.Sum();
        }

        private static List<int[,]> GetAmountOfEdgesAndTotalPositivResults(DataTable data, int indexOfColumnToCheck)
        {
            var foundValues = new List<int[,]>();
            var knownValues = CountKnownValues(data, indexOfColumnToCheck);

            foreach (var item in knownValues)
            {
                var amount = 0;
                var positiveAmount = 0;

                for (var i = 0; i < data.Rows.Count; i++)
                {
                    if (data.Rows[i][indexOfColumnToCheck].ToString().Equals(item))
                    {
                        amount++;

                        //Cuenta los casos positivos y luego agrega la suma a la matriz para el calculo
                        if (data.Rows[i][data.Columns.Count - 1].ToString().Equals(data.Rows[0][data.Columns.Count - 1]))
                        {
                            positiveAmount++;
                        }
                    }
                }
                int[,] array = { { amount, positiveAmount } };
                foundValues.Add(array);
            }
            return foundValues;
        }

        private static IEnumerable<string> CountKnownValues(DataTable data, int indexOfColumnToCheck)
        {
            var knownValues = new List<string>();

            // Agrega el valor en la primera fila 
            if (data.Rows.Count > 0)
            {
                knownValues.Add(data.Rows[0][indexOfColumnToCheck].ToString());
            }

            for (var j = 1; j < data.Rows.Count; j++)
            {
                var newValue = knownValues.All(item => !data.Rows[j][indexOfColumnToCheck].ToString().Equals(item));

                if (newValue)
                {
                    knownValues.Add(data.Rows[j][indexOfColumnToCheck].ToString());
                }
            }
            return knownValues;
        }
    }
}
