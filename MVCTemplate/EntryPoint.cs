using System;

namespace MVCTemplate
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            ModelController controller = new ModelController(new View());
            controller.addModel(controller.createModel("Гарри Поттер", 32234, "Дмитрий","Солодкий"));
            controller.addModel(controller.createModel("Зелёная миля", 32235, "Павел", "Каленик"));
            controller.updateView();
            controller.mainView();
            controller.addModel(controller.createModel(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine()));
            Console.WriteLine("");
            controller.updateView();
        }
    }
}
