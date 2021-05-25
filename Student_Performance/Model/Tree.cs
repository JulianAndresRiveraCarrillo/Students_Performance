using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Performance.Model
{
	class Tree
	{

		public Node buildTre(List<String> atributos, List<List<String>> instancias, List<List<String>> valDiferentes)
		{


			double entrCond, ganan;
			double entropiaTotal = Entropy.calculateEntropy(instancias, valDiferentes);

			/*if (entropiaTotal == 0.0 && !instancias.isEmpty())
			{
				//
				//List<String> instancia = instancias.get(0);
				//List<String> instancia = instancias.get(0);
				//Node nodo = new Node(instancia.get(instancia.Count - 1).toUpperCase(), 0, true);
				//return nodo;

			}*/
			/*else
			{
				List<Double> ganancias = new List<Double>();
				String valor;

				for (int i = 0; i < atributos.Count - 1; i++)
				{
					List<Double> entropiasCondicionadas = new List<Double>();

				//	for (int j = 0; j < valDiferentes.get(i).size(); j++)
					{
					//	valor = valDiferentes.get(i).get(j);
					//	entrCond = Entropy.calculateEntCond(valor, i, instancias, valDiferentes);
					//	entropiasCondicionadas.Add(j, entrCond);
					}

					//ganan = Entropy.calculateGanancia(entropiaTotal, entropiasCondicionadas, instancias, valDiferentes.get(i), i);
				//ganancias.Add(i, ganan);
				}

				int mayorGanancia = Entropy.mayorGanancia(ganancias);

				//Node nodo = new Node(atributos.get(mayorGanancia), mayorGanancia, false);

				//foreach (String auxValor in valDiferentes.get(mayorGanancia))
				{
					//List<List<String>> auxInst = quitarFilas(mayorGanancia, auxValor, instancias);
					//auxInst = quitarColumna(mayorGanancia, auxInst);
					//List<String> auxAtributos = quitarAtributos(mayorGanancia, atributos);
					//List<List<String>> auxValDiferentes = quitarDiferentes(mayorGanancia, valDiferentes);

					//Node aux = buildTre(auxAtributos, auxInst, auxValDiferentes);

					//nodo.setChildren(aux);
					//nodo.setData(auxValor);
				}
				return nodo;*/
			return null;
			}
			

		/*public String prediccion(List<String> instancia, Node nodo)
		{
			if (nodo.isfinal())
			{
				return nodo.getId();
			}
			else
			{
				//String valor = instancia.get(nodo.getPosicionAtributos());
				instancia.Remove(nodo.getPosicionAtributos() + "");
				//int pos = nodo.getData().IndexOf(valor);
				//return prediccion(instancia, nodo.getChildren().get(pos));
			}
		}

		/*public List<String> quitarAtributos(int mayorGanancia, List<String> atributos)
		{
			List<String> aux;
			aux = copiarArrayList(atributos);


			//aux.Remove(mayorGanancia);
			return aux;
		}



		public List<List<String>> quitarColumna(int pos, List<List<String>> auxInst)
		{
			List<List<String>> aux;
			aux = copiarArrayArrayList(auxInst);

			for (int i = 0; i < auxInst.Count; i++)
			{
			//	aux.get(i).remove(pos);
			}
			return aux;
		}

		public List<List<String>> quitarDiferentes(int pos, List<List<String>> valDiferentes)
		{
			List<List<String>> aux;
			aux = copiarArrayArrayList(valDiferentes);

			//aux.remove(pos);
			return aux;
		}


		public List<List<String>> quitarFilas(int pos, String auxValor, List<List<String>> instancias)
		{
			List<List<String>> aux;
			aux = copiarArrayArrayList(instancias);

			foreach (List<String> instancia in instancias)
			{
				//if (!instancia.get(pos).equals(auxValor))
				{
				//	aux.remove(instancia);
				}
			}
			return aux;
		}

		private List<List<String>> copiarArrayArrayList(List<List<String>> instancias)
		{


			return new List<List<String>>(instancias);
		}

		private List<String> copiarArrayList(List<String> atributos)
		{

			return new List<String>(atributos);
		}*/
	}
}

