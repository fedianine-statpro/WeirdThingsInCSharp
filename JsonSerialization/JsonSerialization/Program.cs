DerivedClass derivedClass = new DerivedClass{FirstName = "Victor", EmailAddress = "email"};
BaseClass baseClassValue = derivedClass;
// Surprisingly even though we are using the base class, the derived class property is serialized with Newtonsoft.Json
Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(baseClassValue));
// Since we are using the base class, the derived class property is not serialized with System.Text.Json (as I would expect)
Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(baseClassValue));
Console.ReadLine();

public class BaseClass
{
    public string EmailAddress { get; set; }
}

public class DerivedClass : BaseClass
{
    public string FirstName { get; set; }
}