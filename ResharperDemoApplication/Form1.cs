using System.Collections.Generic;
using System.Windows.Forms;
using ReSharperDemo;

namespace ResharperDemoApplication
{
    ///<summary>
    ///
    ///</summary>
    public partial class Form1 : Form
    {
        private List<Cat> _cat = new List<Cat>();

        ///<summary>
        ///
        ///</summary>
        public Form1()
        {
            InitializeComponent();

            _cat = createCat(5);
        }

        /// <summary>
        /// Creates the cat.
        /// </summary>
        /// <param name="numberOfCats1">The number of cats1.</param>
        /// <returns></returns>
        private List<Cat> createCat(int numberOfCats1)
        {
            var cats = new List<Cat>();
            for (int i = 0; i < numberOfCats1; i++)
            {
                cats.Add(new Cat {Age = 5, Name = "Fluffy" + i});
            }

            return cats;
        }
    }
}