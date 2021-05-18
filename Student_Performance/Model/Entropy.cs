using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Performance.Model
{
	class Entropy
	{
		public static double calculateEntropy(List<List<String>> instancias, List<List<String>> valDiferentes)
		{
			double entropy = 0.0, prob;
			//String valor;
			double numInst = instancias.Count;


			List<String> clases = null;
			if ((valDiferentes.Count - 1) >= 0)
			{
				//clases = valDiferentes.get(valDiferentes.Count - 1);



				int dif = clases.Count;

				for (int i = 0; i < dif; i++)
				{
					//valor = clases.countains
;
					prob = 0.0;
					foreach (List<String> instance in instancias)
					{
						//if (valor.Equals(instance.get(instance.Count - 1)))
						{
							prob++;
						}
					}

					if (prob != numInst && prob != 0)
					{
						//entropy = entropy - (prob / numInst) * (Math.log((prob / numInst)) / Math.log(2));
					}
				}
			}
			return entropy;
		}


		public static double calculateEntCond(String valor, int pos, List<List<String>> instancias, List<List<String>> valDiferentes)
		{

			double entropy = 0.0, prob, numInst;
			String clase;
			//List<String> clases = valDiferentes.get(valDiferentes.Count - 1);
			//int dif = clases.Count;

			//for (int i = 0; i < dif; i++)
			{
			//	clase = clases.get(i);
				prob = 0;
				numInst = 0;

				foreach (List<String> instance in instancias)
				{
					//String auxValor = instance.get(pos);

					//if (valor.Equals(auxValor))
					{
						numInst++;
						//String auxClase = instance.get(instance.Count - 1);
						//if (clase.Equals(auxClase))
						{
							prob++;
						}
					}
				}

				if (prob != numInst && prob != 0)
				{
					//entropy = entropy - ((prob / numInst) * (Math.log((prob / numInst)) / Math.log(2)));
				}
			}
			return entropy;
		}

		public static double calculateGanancia(Double entropy, List<Double> entCond, List<List<String>> instancias, List<String> valDiferentes, int pos)
		{
			double ganancia = entropy, cant;
			String valor;
			double numInst = instancias.Count;
			int dif = valDiferentes.Count;

			for (int i = 0; i < dif; i++)
			{
				//valor = valDiferentes.get(i);
				cant = 0;

				foreach (List<String> instance in instancias)
				{
					//if (valor.Equals(instance.get(pos)))
					{
						cant++;
					}
				}
				//ganancia = ganancia - (cant / numInst) * entCond.Get(i);
			}
			return ganancia;
		}


		public static int mayorGanancia(List<Double> ganancias)
		{
			int posMayor = 0;
			double mayor = 0;

			foreach (Double ganancia in ganancias)
			{
				if (ganancia > mayor)
				{
					posMayor = ganancias.IndexOf(ganancia);
					mayor = ganancia;
				}
			}
			return posMayor;
		}

	}
}
