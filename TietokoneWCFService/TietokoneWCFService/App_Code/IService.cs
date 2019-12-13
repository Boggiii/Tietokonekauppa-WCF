using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    //CPU
    [OperationContract]
    DataSet SelectAllDistinctFromCPU();

    [OperationContract]
    DataSet SelectAllByBrandCPU(string String);

    [OperationContract]
    DataSet SelectByIdFromCPU(int ID);


    //MOBO
    [OperationContract]
    DataSet SelectAllDistinctFromMOBO();

    [OperationContract]
    DataSet SelectAllByBrandMOBO(string String);


    //GPU
    [OperationContract]
    DataSet SelectAllDistinctFromGPU();

    [OperationContract]
    DataSet SelectAllBySeriesGPU(string String);


    //RAM
    [OperationContract]
    DataSet SelectAllDistinctFromRAM();

    [OperationContract]
    DataSet SelectAllByBrandRAM(string String);


    //PSU
    [OperationContract]
    DataSet SelectAllDistinctFromPSU();

    [OperationContract]
    DataSet SelectAllByBrandPSU(string String);

    [OperationContract]
    DataSet SelectPowerByIdFromPSU(int ID);


    //Case
    [OperationContract]
    DataSet SelectAllDistinctFromCase();

    [OperationContract]
    DataSet SelectAllByBrandCase(string String);


    [OperationContract]
    strings DeleteComputerById(int ID);

    [OperationContract]
    DataSet SelectAllComputers();

    [OperationContract]
    string InsertComputerDetails(ComputerDetails computerInfo);

    // TODO: Add your service operations here
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.

[DataContract]
public class ComputerDetails
{
    int id;
    int gpuid;
    int cpuid;
    int moboid;
    int ramid;
    int ramAmount;
    int caseid;
    int psuid;

    [DataMember]
    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    [DataMember]
    public int GPUID
    {
        get { return gpuid; }
        set { gpuid = value; }
    }

    [DataMember]
    public int CPUID
    {
        get { return cpuid; }
        set { cpuid = value; }
    }

    [DataMember]
    public int MOBOID
    {
        get { return moboid; }
        set { moboid = value; }
    }

    [DataMember]
    public int RAMID
    {
        get { return ramid; }
        set { ramid = value; }
    }

    [DataMember]
    public int RAMamount
    {
        get { return ramAmount; }
        set { ramAmount = value; }
    }

    [DataMember]
    public int CASEID
    {
        get { return caseid; }
        set { caseid = value; }
    }

    [DataMember]
    public int PSUID
    {
        get { return psuid; }
        set { psuid = value; }
    }
}
