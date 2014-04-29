namespace ReSharperDemo
{
    ///<summary>
    /// Contains basic properties and methods for an animal
    ///</summary>
    public interface IAnimal
    {
        ///<summary>
        /// Allows the animal to speak
        ///</summary>
        void Speak();

        ///<summary>
        /// The name of the animal
        ///</summary>
        string Name { get; set; }

        ///<summary>
        /// The age of the animal
        ///</summary>
        long Age { get; set; }
    }
}