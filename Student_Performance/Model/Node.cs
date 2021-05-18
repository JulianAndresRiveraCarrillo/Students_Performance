using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Performance.Model
{
	class Node
	{
		private String id;
		private int posicionAtributos;
		public ArrayList children;
		public ArrayList valores;
		private bool isfinal2;



		public Node(String id, int pos, bool isfinal)
		{

			this.id = id;
			this.posicionAtributos = pos;
			this.children = new ArrayList();
			this.valores = new ArrayList();
			this.isfinal2 = isfinal;
		}
		public String getId()
		{
			return id;
		}

		public int getPosicionAtributos()
		{
			return posicionAtributos;
		}

		public void setData(String data)
		{
			valores.Add(data);
		}

		public ArrayList getData()
		{
			return valores;
		}

		public void setChildren(Node nodo)
		{
			children.Add(nodo);
		}

		public ArrayList getChildren()
		{
			return children;
		}

		public bool isfinal()
		{
			return isfinal2;
		}

		public void pintarArbol(Node nodo, int nivel)
		{
			Console.WriteLine(nodo.getId());

			if (!nodo.isfinal())
			{
				ArrayList hijos = nodo.getChildren();
				ArrayList data = nodo.getData();
				String valor;

				for (int i = 0; i < data.Count; i++)
				{
				//	valor = data.get(i);
					pintarSangria(nivel);
					//Console.WriteLine(valor + "-->");
				//	pintarArbol(hijos.get(i), nivel + 2);
				}
			}
		}

		private void pintarSangria(int nivel)
		{
			for (int i = 0; i < nivel; i++)
			{
				Console.WriteLine("             ");
			}

		}


	}
}
