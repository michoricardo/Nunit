Nunit has more tools than MSTest, so We'll be using this.
![image](https://user-images.githubusercontent.com/44788583/169329893-84a2b20a-5676-45de-9dd0-641745778bb7.png)

Add a class library project in the solution
![image](https://user-images.githubusercontent.com/44788583/169330234-58ec6366-a496-449b-8cff-9c56319022fa.png)

Click on the project and manage nuget packages
![image](https://user-images.githubusercontent.com/44788583/169330999-7707ef19-afb7-4c3c-af34-8d7fabe8ec12.png)

Look for Nunit and install it
![image](https://user-images.githubusercontent.com/44788583/169331483-506782e5-3a37-4e0c-9203-1b594e06d283.png)

Now it is installed

![image](https://user-images.githubusercontent.com/44788583/169331711-72a6e3e6-13cb-4950-b50a-e1e54282820b.png)

Look for the nunit3test adapter and install it
![image](https://user-images.githubusercontent.com/44788583/169331951-5f5b904a-9f33-4a8d-bf49-f74347e32a50.png)

Look for Microsoft.Net.Test.sdk and install it also
![image](https://user-images.githubusercontent.com/44788583/169332263-41318254-edf2-4573-8e46-51d38f30e45b.png)

Change the default namespace

![image](https://user-images.githubusercontent.com/44788583/169334499-eac32c68-0211-41ef-8bf3-bb0b46463640.png)

![image](https://user-images.githubusercontent.com/44788583/169334600-572d175d-d70a-4a90-8f5f-58f0e06d1dec.png)

Now We use the [TestFixture] property. Do a CTRL + . TO add the reference of NUnit in the using property as before.
![image](https://user-images.githubusercontent.com/44788583/169335402-19a0472c-55e8-4b28-a6a5-ea13fc929858.png)

I copied the test from the MSTest file, then Calculator is not detected even with a CTRL + .
![image](https://user-images.githubusercontent.com/44788583/169335941-4a4e67e0-cfb0-4ee4-b3f2-1484d4b5e972.png)

In dependencies, add new project reference: 
![image](https://user-images.githubusercontent.com/44788583/169336105-3c529967-5d37-4e8b-a686-6f18981864e1.png)

![image](https://user-images.githubusercontent.com/44788583/169336197-f27367a5-6d9a-4f64-92f5-bf6516697ae4.png)

![image](https://user-images.githubusercontent.com/44788583/169336253-6852ed8a-e56e-443c-97db-4e07ee60da7d.png)
