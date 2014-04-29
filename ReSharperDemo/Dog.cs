using System;

namespace ReSharperDemo
{
    ///<summary>
    /// The implementation of Dog
    ///</summary>
    public class Dog : IAnimal
    {
        ///<summary>
        /// Allows the animal to speak
        ///</summary>
        public void Speak()
        {
            Console.WriteLine("From Dog");
        }

        ///<summary>
        /// The name of the animal
        ///</summary>
        public string Name { get; set; }


        ///<summary>
        /// The age of the animal
        ///</summary>
        public long Age { get; set; }
    }
}
