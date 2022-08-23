using System;

namespace ReizTask
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //===================================CLOCK TASK===============================================

            /*Clock clock = new Clock();

            clock.Angle();*/




            //============================HIERARCHICAL STRUCTURE TASK====================================

            var structure = new Structure()
            {
                structures = {
                    new Structure() { structures =
                        {new Structure() }
                    },

                    new Structure() { structures = {
                            new Structure() {structures = {
                                    new Structure() }
                            } ,

                    new Structure() {structures = {
                            new Structure() {structures = {
                                    new Structure() }
                            },

                    new Structure() }
                    },


                    new Structure() }
                    }

                }
            };

            Console.WriteLine($"Depth is {Structure.Depth(structure)}.");

        }

    }
}
