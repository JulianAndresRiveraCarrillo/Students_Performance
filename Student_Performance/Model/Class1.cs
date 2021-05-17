using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Performance.Model
{
    class dTree
    {

        private float nodeGainRatio;
        private float nodeInformationGain;
        private Boolean isLeaf;
        private int majorityClass;
        private int bestAttribute;
        private dTree[] children;
        private dTree parent;

        public dTree(float nodeGainRatio, float nodeInformationGain, Boolean isLeaf, int majorityClass, int bestAttribute, dTree parent)
        {

            this.nodeGainRatio = nodeGainRatio;
            this.nodeInformationGain = nodeInformationGain;
            this.isLeaf = isLeaf;
            this.majorityClass = majorityClass;
            this.bestAttribute = bestAttribute;
            this.parent = parent;
            children = new 
        }
    }
}
