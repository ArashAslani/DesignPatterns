﻿using Facade.FacadeFromUML.Package1;
using Facade.FacadeFromUML.Package2;
using Facade.FacadeFromUML.Package3;

namespace Facade.Facade;

public class FacadeService
{
    public void DoSomthing()
    {
        Class1 class1 = new();
        Class2 class2 = new();
        Class3 class3 = new();

        class1.Action1();
        class2.Action2();
        class3.Action3(); 

        class1.StopAction();
    }
}
