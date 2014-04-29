using System;

namespace ReSharperDemo
{
    ///<summary>
    /// The implementation of ThisIsAReallyLongAnimal
    ///</summary>
    public class ThisIsAReallyLongAnimal: IAnimal
    {
        ///<summary>
        /// Allows the animal to speak
        ///</summary>
        public void Speak()
        {
            Console.WriteLine("From ThisIsAReallyLongAnimal");
        }

        ///<summary>
        /// The name of the animal
        ///</summary>
        public string Name
        {
            get; 
            set;
        }

        ///<summary>
        /// The age of the animal
        ///</summary>
        public long Age
        {
            get;
            set;
        }
    }
}