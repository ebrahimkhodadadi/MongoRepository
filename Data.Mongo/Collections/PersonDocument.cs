using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mongo.Collections;

public class PersonDocument : MongoBaseDocument
{
    public string Name { get; set; }
    public string Family { get; set; }
}
