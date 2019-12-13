using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{ 
    //CPU
    public DataSet SelectAllDistinctFromCPU()
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("select distinct Merkki from CPU", con);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet distinct = new DataSet();

        sda.Fill(distinct);
        cmd.ExecuteNonQuery();
        con.Close();

        return distinct;
    }

    public DataSet SelectAllByBrandCPU(string String)
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from CPU where Merkki = @String", con);
        cmd.Parameters.AddWithValue("@String", String);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet dsCpuModelsByBrand = new DataSet();

        sda.Fill(dsCpuModelsByBrand);
        cmd.ExecuteNonQuery();
        con.Close();

        return dsCpuModelsByBrand;
    }

    public DataSet SelectByIdFromCPU(int ID)
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from CPU where Id = @ID", con);
        cmd.Parameters.AddWithValue("@ID", ID);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        sda.Fill(ds);
        cmd.ExecuteNonQuery();
        con.Close();
        return ds;
    }

    //MOBO
    public DataSet SelectAllDistinctFromMOBO()
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("select distinct Merkki from MOBO", con);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet distinct = new DataSet();

        sda.Fill(distinct);
        cmd.ExecuteNonQuery();
        con.Close();

        return distinct;
    }

    public DataSet SelectAllByBrandMOBO(string String)
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from MOBO where Merkki = @String", con);
        cmd.Parameters.AddWithValue("@String", String);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet dsMoboModelsByBrand = new DataSet();

        sda.Fill(dsMoboModelsByBrand);
        cmd.ExecuteNonQuery();
        con.Close();

        return dsMoboModelsByBrand;
    }

    //GPU
    public DataSet SelectAllDistinctFromGPU()
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("select distinct Sarja from GPU", con);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet distinct = new DataSet();

        sda.Fill(distinct);
        cmd.ExecuteNonQuery();
        con.Close();

        return distinct;
    }

    public DataSet SelectAllBySeriesGPU(string String)
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from GPU where Sarja = @String", con);
        cmd.Parameters.AddWithValue("@String", String);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet dsGpuModelsByBrand = new DataSet();

        sda.Fill(dsGpuModelsByBrand);
        cmd.ExecuteNonQuery();
        con.Close();

        return dsGpuModelsByBrand;
    }

    //RAM
    public DataSet SelectAllDistinctFromRAM()
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("select distinct Merkki from RAM", con);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet distinct = new DataSet();

        sda.Fill(distinct);
        cmd.ExecuteNonQuery();
        con.Close();

        return distinct;
    }

    public DataSet SelectAllByBrandRAM(string String)
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from RAM where Merkki = @String", con);
        cmd.Parameters.AddWithValue("@String", String);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet dsRAM = new DataSet();

        sda.Fill(dsRAM);
        cmd.ExecuteNonQuery();
        con.Close();

        return dsRAM;
    }

    //PSU
    public DataSet SelectAllDistinctFromPSU()
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("select distinct Merkki from PSU", con);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet distinct = new DataSet();

        sda.Fill(distinct);
        cmd.ExecuteNonQuery();
        con.Close();

        return distinct;
    }

    public DataSet SelectAllByBrandPSU(string String)
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from PSU where Merkki = @String", con);
        cmd.Parameters.AddWithValue("@String", String);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();

        sda.Fill(ds);
        cmd.ExecuteNonQuery();
        con.Close();

        return ds;
    }

    public DataSet SelectPowerByIdFromPSU(int ID)
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("select Teho from PSU where Id = @ID", con);
        cmd.Parameters.AddWithValue("@ID", ID);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        sda.Fill(ds);
        cmd.ExecuteNonQuery();
        con.Close();
        return ds;
    }

    //Case
    public DataSet SelectAllDistinctFromCase()
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("select distinct Merkki from CCase", con);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet distinct = new DataSet();

        sda.Fill(distinct);
        cmd.ExecuteNonQuery();
        con.Close();

        return distinct;
    }

    public DataSet SelectAllByBrandCase(string String)
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from CCase where Merkki = @String", con);
        cmd.Parameters.AddWithValue("@String", String);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();

        sda.Fill(ds);
        cmd.ExecuteNonQuery();
        con.Close();

        return ds;
    }

    //Computers
    public string DeleteComputerById(int ID)
    {
        string palaute;

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("delete from Tietokoneet where Id = @ID", con);
        cmd.Parameters.AddWithValue("@ID", ID);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        int result = cmd.ExecuteNonQuery();
        if (result == 1)
        {
            palaute = "Computer deleted from database.";
        }
        else
        {
            palaute = "Computer was not successfully deleted.";
        }
        con.Close();

        return palaute;
    }

    public DataSet SelectAllComputers()
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT Tietokoneet.Id, GPU.Sarja, GPU.GraphicsCard, GPU_ID, CPU.Merkki, CPU.Prosessori, CPU.Cores, CPU.Threads, CPU.ClockSpeedGHZ, CPU_Id, MOBO.Merkki, MOBO.Malli, MOBO_ID, RAM.Merkki, RAM.ClockSpeedMHZ, RAMamount, RAM_ID, CCase.Merkki, CCase.Malli, Case_ID, PSU.Merkki, PSU.Malli, PSU.Teho, PSU_ID FROM Tietokoneet INNER JOIN GPU ON Tietokoneet.GPU_ID = GPU.Id INNER JOIN CPU ON Tietokoneet.CPU_ID = CPU.Id INNER JOIN MOBO ON Tietokoneet.MOBO_ID = MOBO.Id INNER JOIN RAM ON Tietokoneet.RAM_ID = RAM.Id INNER JOIN CCase ON Tietokoneet.Case_ID = CCase.Id INNER JOIN PSU ON Tietokoneet.PSU_ID = PSU.Id; ", con);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        sda.Fill(ds);
        cmd.ExecuteNonQuery();
        con.Close();
        return ds;
    }

    public string InsertComputerDetails(ComputerDetails computerInfo)
    {
        string Message;
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TietokoneKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into Tietokoneet(GPU_ID,CPU_ID,MOBO_ID,RAM_ID,RAMamount,Case_ID,PSU_ID) values(@GPUID,@CPUID,@MOBOID,@RAMID,@RAMamount,@CASEID,@PSUID)", con);
        
        cmd.Parameters.AddWithValue("@GPUID", computerInfo.GPUID);
        cmd.Parameters.AddWithValue("@CPUID", computerInfo.CPUID);
        cmd.Parameters.AddWithValue("@MOBOID", computerInfo.MOBOID);
        cmd.Parameters.AddWithValue("@RAMID", computerInfo.RAMID);
        cmd.Parameters.AddWithValue("@RAMamount", computerInfo.RAMamount);
        cmd.Parameters.AddWithValue("@CASEID", computerInfo.CASEID);
        cmd.Parameters.AddWithValue("@PSUID", computerInfo.PSUID);


        int result = cmd.ExecuteNonQuery();
        if (result == 1)
        {
            Message = "Details inserted successfully";
        }
        else
        {
            Message = "Details not inserted successfully";
        }
        con.Close();
        return Message;

    }
}
