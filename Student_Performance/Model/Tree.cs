using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Student_Performance.Model
{
     class Tree
    {
        private static string prediction;
        public Node Root { get; set; }

        public static string Print(Node node, string result)
        {
            if (node?.ChildNodes == null || node.ChildNodes.Count == 0)
            {
                var seperatedResult = result.Split(' ');

                foreach (var item in seperatedResult)
                {
                    if (item.Equals(seperatedResult[0]))
                    {
                        prediction += item.ToUpper() + " ";
                    }
                    else if (item.Equals("--") || item.Equals("-->"))
                    {
                        prediction += item + " ";
                    }
                    else if (item.Equals("YES") || item.Equals("NO"))
                    {
                        prediction += "(" + item.ToUpper() + ")";
                    }
                    else if (item.ToUpper().Equals(item))
                    {
                        prediction += item + " ";
                    }
                    else
                    {
                        prediction += item + " ";
                    }

                }

                prediction += "\n";

                return prediction;
            }

            foreach (var child in node.ChildNodes)
            {
                Print(child, result + " -- " + child.Edge.ToLower() + " --> " + child.Name.ToUpper());
            }

            return prediction;  
        }

        public static string PrintResult(Node node, string result)
        {
            string pred = " ";

            if (node?.ChildNodes == null || node.ChildNodes.Count == 0)
            {
                var seperatedResult = result.Split(' ');

                foreach (var item in seperatedResult)
                {
                    if (item.Equals(seperatedResult[0]))
                    {
                        pred += item.ToUpper() + " ";
                    }
                    else if (item.Equals("--") || item.Equals("-->"))
                    {
                        pred += item + " ";
                    }
                    else if (item.Equals("YES") || item.Equals("NO"))
                    {
                        pred += "(" + item.ToUpper() + ")";
                    }
                    else if (item.ToUpper().Equals(item))
                    {
                        pred += item + " ";
                    }
                    else
                    {
                        pred += item + " ";
                    }

                }

                pred += "\n";

                return pred;
            }

            foreach (var child in node.ChildNodes)
            {
                Print(child, result + " -- " + child.Edge.ToLower() + " --> " + child.Name.ToUpper());
            }

            return pred;
        }

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

            // Si la entrada es un atributo invalido 
            if (!valueFound)
            {
                result = "Atributo no encontrado";
            }

            return result;
        }

        public static Node Learn(DataTable data, string edgeName)
        {
            var root = GetRootNode(data, edgeName);

            foreach (var item in root.NodeAttribute.DifferentAttributeNames)
            {
                // si es una hoja, se agregará hoja en este método
                var isLeaf = CheckIfIsLeaf(root, data, item);

                // hacer una llamada recursiva siempre que el nodo no sea una hoja
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

            // Obtener todos los valores de hoja para el atributo en cuestión
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

            // crear una hoja con valor para mostrar y edge a la hoja
            if (isLeaf)
            {
                root.ChildNodes.Add(new Node(true, allEndValues[0], attributeToCheck));
            }

            return isLeaf;
        }

        private static DataTable CreateSmallerTable(DataTable data, string edgePointingToNextNode, int rootTableIndex)
        {
            var smallerData = new DataTable();

            // Agregar títulos de columna
            for (var i = 0; i < data.Columns.Count; i++)
            {
                smallerData.Columns.Add(data.Columns[i].ToString());
            }

            // Agregar filas que contienen edgePointingToNextNode a la nueva tabla de datos
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

            // Eliminar la columna que ya se usó como nodo      
            smallerData.Columns.Remove(smallerData.Columns[rootTableIndex]);

            return smallerData;
        }

        private static Node GetRootNode(DataTable data, string edge)
        {
            var attributes = new List<Attribute>();
            var highestInformationGainIndex = -1;
            var highestInformationGain = double.MinValue;

            // Obtenga todos los nombres, cantidad de atributos y atributos para cada columna            
            for (var i = 0; i < data.Columns.Count-1; i++)
            {
                var differentAttributenames = Attribute.GetDifferentAttributeNamesOfColumn(data, i);
                attributes.Add(new Attribute(data.Columns[i].ToString(), differentAttributenames));
            }

            // Calcular la entropía (S)
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
                // Ayudante para el cálculo
                var firstDivision = item[0, 1] / (double)item[0, 0];
                var secondDivision = (item[0, 0] - item[0, 1]) / (double)item[0, 0];

                // Previene dividedByZeroException
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

                        // Cuenta los casos positivos y luego agrega la suma a la matriz para el cálculo
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

            // Agrega el valor de la primera fila a la lista
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
