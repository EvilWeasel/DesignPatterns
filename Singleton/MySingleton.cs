using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
  public class MySingleton
  {
    // Privates Feld für die Klasse
    private static MySingleton _instance;

    // Privater Konstruktor, damit nur innerhalb der Klasse Instanzen erzeugt werden können
    private MySingleton() { }

    // Öffentliche Eigenschaft, um die Instanz zu erhalten
    // Könnte man auch als öffentliches Interface für die private Instanz sehen
    public static MySingleton Instance
    {
      get
      {
        // Wenn noch keine Instanz existiert, dann wird eine neue erzeugt
        if (_instance == null)
        {
          _instance = new MySingleton();
        }
        return _instance;
      }
    }
  }
}
