using System.Reflection;
using Task_11._1;

FirstClass firstClass = new FirstClass();
PropertyInfo[] props = typeof(FirstClass).GetProperties();


foreach (var item in props)
{
    try
    {
        if (item.IsDefined(typeof(NameAttribute)))
        {
            NameAttribute customAttr = (NameAttribute)item.GetCustomAttribute(typeof(NameAttribute));
            Console.WriteLine($"{item.Name} - {customAttr.Description}");
        }
        else throw new NullReferenceException();
    }
    catch (NullReferenceException)
    {
        Console.WriteLine($"{item.Name} - Атрибут NameAttribute отсутствует");
        continue;

    }

   
    //var attr = (NameAttribute)arr[0];
    //Console.WriteLine(attr.Description);
    //Console.WriteLine($"{item.Name} - {item}");
}