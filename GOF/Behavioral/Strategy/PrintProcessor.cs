using System;
using System.Collections.Generic;

namespace GOF.Behavioral.Strategy
{
    //such class does not know anything about how to print (read,write,calc etc)
    //it only needs to print some message. somehow
    //pattern does not specify how the class gets IStrategyInterface instances
    class PrintProcessor 
    {
        private readonly Action<string> _printMessage; //also it can be delegate/Func/Action
        //if there is only one method in interface it might be better with such approach
        public PrintProcessor(Action<string> printer)
        {
            _printMessage = printer;
        }
        public void PrintMessages(List<IPrintMessage> toPrint)
        {
            toPrint.ForEach(p => p.PrintMessage("Sample Message"));
            _printMessage("SampleMessage");
        }

        
    }
}