## Create new project:

File/ create new project / blank solution

![image](https://user-images.githubusercontent.com/44788583/168906009-ee1bf603-b854-403c-aeb7-fe74ea01eee8.png)

Change the folder of location to desired: 
![image](https://user-images.githubusercontent.com/44788583/168906248-d1a67382-d995-4776-b7f5-0d4237f58284.png)

Right click on the solution  and select add new project 
![image](https://user-images.githubusercontent.com/44788583/168906683-0373e03f-eaa1-40c1-9e76-4124002e170e.png)

We select the class Library type project and give the same name of the project 
![image](https://user-images.githubusercontent.com/44788583/168906860-ecbd966d-659b-4c13-9332-6f3909fe472f.png)
Selected .NET 5.0

Change the name and select YES on changing the references:
![image](https://user-images.githubusercontent.com/44788583/168908283-2ff7378d-8ea2-4b51-a76e-163def8f37c0.png)

We add a method and later on We will test this method with a unit test
![image](https://user-images.githubusercontent.com/44788583/168909009-89ac5753-069e-4c16-a1bb-591825302570.png)

To test We add a new project as We did before, but now We add MSTest Test Project
![image](https://user-images.githubusercontent.com/44788583/168909909-9abb4122-fb36-49f8-b6c2-995ee8670ff8.png)

We name it on preference and reference
![image](https://user-images.githubusercontent.com/44788583/168910092-6d22153a-c29c-4187-ab8c-f2c133778b80.png)

Notice there were added some packages. Also We are going to erase UnitTest1.cs to start from scratch.
![image](https://user-images.githubusercontent.com/44788583/168910369-fcfdc54a-ee55-47bb-bfe2-f6fb936bdf59.png)

Go to SparkyMSTest and add a new item
![image](https://user-images.githubusercontent.com/44788583/168911817-382526f9-5c28-4533-b51e-f6a824e66c9c.png)

Select class file
![image](https://user-images.githubusercontent.com/44788583/168911913-460ed211-66da-4808-bb58-4755fcf2b206.png)

Some changes need to be made in the class to be as test classes 
![image](https://user-images.githubusercontent.com/44788583/168912151-de3f5168-04b2-4f17-8f18-f8a9628311ca.png)

We need to change the parameter of [TestClass] do a CTRL . to add the correct using namespace
Notice We changed the using parameter on top, We added TestClass parameter, then We changed from internal to public class and finally We changed the name of the class
![image](https://user-images.githubusercontent.com/44788583/168912583-33df28b5-ae9a-4d99-afbb-61caff12c9b9.png)

Then We added a test method
![image](https://user-images.githubusercontent.com/44788583/168915125-64b3a6d6-f837-4cf6-be37-63be4f8f8d2c.png)

We create an object but We need to add reference to the class We will require to check, in this case, We need to check the Calculator.cs
![image](https://user-images.githubusercontent.com/44788583/168916948-b9ff63ed-e7c2-43d7-b3f1-3c4dba392684.png)
![image](https://user-images.githubusercontent.com/44788583/168917035-c87a215a-f794-40fd-8164-92e582cfdeaa.png)

Once the inizialization is done, We add the act and the assert part of the test
![image](https://user-images.githubusercontent.com/44788583/168918281-fef1f6dc-2765-44fc-884f-50612cab5c3f.png)
In the assert and the method AreEqual, the first parameter is the expected result and the second one the real result


