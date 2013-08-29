using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SimpleServiceSample
{
    [DataContract]
    public class Name
    {
        [DataMember]
        public string first;
        [DataMember]
        public string last;
    }

    [ServiceContract]
    public interface ISimpleService
    {
        [OperationContract]
        string SayHello(Name Person);
    }

    class SimpleService : ISimpleService
    {
        public string SayHello(Name person)
        {
            return string.Format("Hi {0} {1}", person.first, person.last);
        }
    }
}