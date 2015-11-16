using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Chain
{
    public static List<string> lst = new List<string>();


}


// "Handler" 

abstract class Engine
{
    protected Engine _next;

    public void NextEngine(Engine successor)
    {
        this._next = successor;
    }

    public void Process(Input input)
    {
        if (CheckSignature(input))
        {

            Chain.lst.Add(string.Format("{0} found in file: {1}", this.GetType().Name, input.Filename));

        }
        else if (_next != null)
        {
            _next.Process(input);
        }

    }
    public abstract bool CheckSignature(Input input);
}



class Worm : Engine
{
    public override bool CheckSignature(Input input)
    {
        return input.Header.ToLower().IndexOf("worm") != -1;
    }
}



class TorjanHorse : Engine
{
    public override bool CheckSignature(Input input)
    {
        return input.Header.ToLower().IndexOf("torjan") != -1;
    }
}



class Spyware : Engine
{
    public override bool CheckSignature(Input input)
    {
        return input.Header.ToLower().IndexOf("spyware") != -1;
    }
}



class Input
{
    string filename;

    public string Filename
    {
        get { return filename; }

    }
    string header;

    public string Header
    {
        get { return header ?? ""; }

    }

    public Input(string FileName, string Header)
    {
        filename = FileName;
        header = Header;

    }

}


