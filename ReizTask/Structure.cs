using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTask
{
	
	internal class Structure
	{
		public List<Structure> structures = new List<Structure>();


        public static int Depth(Structure structure)
        {
            var structuresList = new List<int>();

            if (structure.structures.Count == 0)
            {
                return 1;
            }
            foreach (Structure childStructure in structure.structures)
            {
                structuresList.Add(Depth(childStructure));
            }
            return structuresList.Max() + 1;
        }

    }
}
