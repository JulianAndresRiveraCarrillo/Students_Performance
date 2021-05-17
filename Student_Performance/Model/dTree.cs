using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Performance.Model
{
    class Dtree
    {

            private float nodeGainRatio;
            private float nodeInformationGain;
            private Boolean isLeaf;
            private int majorityClass;
            private int bestAttribute;
            private Dtree[] children;
            private Dtree parent;

        public Dtree()
        {
            parent = null;
        }

        public void buildTree(string[] arrayAtributes, string[] labels, Dtree self)
        {
            //numInstances
            //nodeInfo
            majorityClass = frequenlyValue(labels);

            
        }
        
        public string[] segregate(string[] arrayAtributes, string value)
        {
            string[] output = new string[arrayAtributes.Length];

            for(int i = 0; i < arrayAtributes.Length; i++)
            {
                if(arrayAtributes[i] == value)
                {
                    output[i] = arrayAtributes[i];
                }
            }

            return output;
        }

        public double computeEntropy(string[] labels)
        {
            double entropy = 0;

            for(int i = 0; i < labels.Length; i++)
            {
                double problability = segregate(labels, labels[i]).Length / labels.Length;
                entropy -= problability * Math.Log(problability, 2);
            }

            return entropy;
        }

        public int frequenlyValue(string [] labels)
        {
            int bestCount = -1;
            int bestID = 0;

            for(int i = 0; i < labels.Length; i++)
            {
                int count = segregate(labels, labels[i]).Length;
                
                if(count > bestCount)
                {
                    bestCount = count;
                    bestID = i;
                }
            }

            return bestID;
        }





    }
}
