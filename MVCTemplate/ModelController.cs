using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace MVCTemplate
{
    public class ModelController
    {
        Regex r1 = new Regex("[а-яА-Я]*$");
        Regex r2 = new Regex("[0-9][0-9][0-9][0-9][0-9]");
        private View view;
        private List<Model> modelList = new List<Model>();

        public ModelController(View view)
        {
            this.view = view;
        }
        
        public void addModel(Model model)
        {
            modelList.Add(model);
        }

        public Model createModel(String name,int number, String firstName,String lastName)
        {
            if (r1.IsMatch(name))
            {
                if (r2.IsMatch(number.ToString()))
                {
                    if (r1.IsMatch(firstName))
                    {
                        if (r1.IsMatch(lastName))
                        {
                            return new Model(name, number, firstName, lastName);
                        }
                        else throw new Exception("There is false data entering. Please, enter letter format");
                    }
                    else throw new Exception("There is false data entering. Please, enter letter format");
                }
                else throw new Exception("There is false data entering. Please, enter 5 numeral format ");
            }
            else throw new Exception("There is false data entering. Please, enter letter format");

           
        }

        public void updateView()
        {
            foreach (Model model in modelList)
            {
                view.printModelName(model);
            }
        }
        public void mainView()
        {
            view.printMainMenu();
        }
    }
}
