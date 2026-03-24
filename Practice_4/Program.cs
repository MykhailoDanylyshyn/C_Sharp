using System;

class City 
{
    private string name;
    private int population;
    private string country;
    private string districts;
    private string code;

    public string Name 
    {
        get
        {
            return name;
        }
        set
        {
            if (value != "")
                name = value;
        }
    }

    public int Population
    {
        get
        {
            return population;
        }
        set
        {
            if (value >0)
                population = value;
        }
    }

    public string Country
    {
        get
        {
            return country;
        }
        set
        {
            if(value !="")
                country = value;
        }
    }

    public string Districts
    {
        get
        {
            return districts;
        }
        set
        {
            if (value != "")
                districts = value;
        }
    }

    public string Code
    {
        get
        {
            return code;
        }
        set
        {
            bool allnums = true;
            foreach (char c in code)
                if (!Char.IsNumber(c))
                    allnums = false;
            if (code.Length >=3 && code.Length < 5 && allnums)
                code = value;
        }
    }

}