using System;

namespace wcf
{
    public class MyService : IMyService
    {

        public string GetName(String name) {
            return "Your name is " + name;
        }
    }
}