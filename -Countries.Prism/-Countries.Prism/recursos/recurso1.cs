using System;
using System.Collections.Generic;
using System.Text;

namespace -Countries.Prism.recursos
{

class recurso1
{
    private static System.Resources.ResourceManager resourceMan;
    private static System.Globalization.CultureInfo resourceCulture;
    public static System.Resources.ResourceManager ResourceManager
    {
        get
        {
            if (object.Equals(null, resourceMan))
            {
                System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Pais.recursos.recurso1", typeof(recurso1).Assembly);
                resourceMan = temp;
            }
            return resourceMan;
        }
    public static string Countries
    {
        get
        {
            return ResourceManager.GetString("Countries", resourceCulture);
        }
    }

    public static string Country
    {
        get
        {
            return ResourceManager.GetString("Country", resourceCulture);
        }
    }

    public static string Information
    {
        get
        {
            return ResourceManager.GetString("Information", resourceCulture);
        }
    }

    public static string Capital
    {
        get
        {
            return ResourceManager.GetString("Capital", resourceCulture);
        }
    }

    public static string Population
    {
        get
        {
            return ResourceManager.GetString("Population", resourceCulture);
        }
    }

    public static string Area
    {
        get
        {
            return ResourceManager.GetString("Area", resourceCulture);
        }
    }

    public static string AlphaCode2
    {
        get
        {
            return ResourceManager.GetString("AlphaCode2", resourceCulture);
        }
    }

    public static string AlphaCode3
    {
        get
        {
            return ResourceManager.GetString("AlphaCode3", resourceCulture);
        }
    }

    public static string Region
    {
        get
        {
            return ResourceManager.GetString("Region", resourceCulture);
        }
    }

    public static string Subregion
    {
        get
        {
            return ResourceManager.GetString("Subregion", resourceCulture);
        }
    }

    public static string Moneda
    {
        get
        {
    
        return ResourceManager.GetString("Currencies", resourceCulture);
        }
    }
public static string German
    {
        get
        {
            return ResourceManager.GetString("German", resourceCulture);
        }
    }

    public static string Spanish
    {
        get
        {
            return ResourceManager.GetString("Spanish", resourceCulture);
        }
    }

    public static string French
    {
        get
        {
            return ResourceManager.GetString("French", resourceCulture);
        }
    }

    public static string Japanese
    {
        get
        {
            return ResourceManager.GetString("Japanese", resourceCulture);
        }
    }

    public static string Italian
    {
        get
        {
            return ResourceManager.GetString("Italian", resourceCulture);
        }
    }

    public static string Brazilian
    {
        get
        {
            return ResourceManager.GetString("Brazilian", resourceCulture);
        }
    }

    public static string Portuguese
    {
        get
        {
            return ResourceManager.GetString("Portuguese", resourceCulture);
        }
    }

    public static string Dutch
    {
        get
        {
            return ResourceManager.GetString("Dutch", resourceCulture);
        }
    }

    public static string Croatian
    {
        get
        {
            return ResourceManager.GetString("Croatian", resourceCulture);
        }
    }

    public static string Persian
    {
        get
        {
            return ResourceManager.GetString("Persian", resourceCulture);
        }
    }

    public static string Translations
    {
        get
        {
            return ResourceManager.GetString("Translations", resourceCulture);
        }
    }

}
}
