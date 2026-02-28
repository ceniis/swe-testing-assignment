# Quick-Calc
A basic calculator application.    

***Operation:***
- Addition
- Subtraction
- Multiplication
- Division
- Clear (C)
  
    - :negative_squared_cross_mark: You cannot use the keyboard to enter values or operations
    - :negative_squared_cross_mark: You cannot enter number more than 100_000
    - :white_check_mark: Non-negative integer values
      
- # Appearance:
<img width="201" height="302" alt="image" src="https://github.com/user-attachments/assets/6e7bdfa4-3aad-49ed-8c4b-2fa8bed1a940" />

- # Setup Instructions
1. Clone the repository:
```
git clone https://github.com/<your-username>/<repository-name>.git   
cd <repository-name>
```
2. Open the solution file (```.sln```) in IDE
3. Press Ctrl+Shift+B or select Build → Build Solution
4. Press ```F5``` to debug or ```Ctrl+F5``` to run without debugging

- # Test Frameworks
***NUnit***     
- Open-source unit testing framework for .NET
- Supports parameterized tests, setup/teardown methods, assertions, and exception testing    
- Allows test categorization for selective execution    
- Simple and readable syntax    
- Integrates with Visual Studio Test Explorer and CI/CD pipelines    
- Cross-platform support via dotnet test   
- Large community support and extensive documentation      

***MSTest***     
- Microsoft’s official testing framework for .NET    
- Pre-installed with Visual Studio (minimal setup required)    
- Supports unit tests, setup/cleanup methods, and data-driven tests   
- Tightly integrated with Visual Studio and Azure DevOps pipelines   
- Simpler for beginners but less flexible than NUnit (limited parameterized test support)
    
I chose **NUnit** because it is more flexibile, has good documentstion and I have more expirience with it.

- # Test Run
1. Restore NuGet dependencies:
- Go to Tools → NuGet Package Manager → Manage NuGet Packages for Solution
- Ensure packages like ```NUnit``` and ```NUnit3TestAdapter``` are installed
- Press ```Ctrl+R, V``` to run all unit tests
