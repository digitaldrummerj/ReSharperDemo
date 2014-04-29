using System;

namespace ReSharperDemo
{
    ///<summary>
    /// The cat implementation
    ///</summary>
    public class Cat : IAnimal
    {
        ///<summary>
        /// Allows the animal to speak
        ///</summary>
        public void Speak()
        {
            Console.WriteLine("From Cat");
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

        public bool Equals(Cat other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Name, Name) && other.Age == Age;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (Cat)) return false;
            return Equals((Cat) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0)*397) ^ Age.GetHashCode();
            }
        }
    }
}