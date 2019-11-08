using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class InformationService
    {
        public static List<Information> listInfor = new List<Information>();

        public List<Information> createData()
        {

            for (int i = 0; i < 1; i++)
            {
                listInfor.Add(
                new Information
                {
                    Id = i,
                    Name = "Hoang L " + i,
                    Age = 15 + i,
                    Status = false
                });
            }

            return listInfor;
        }

        public List<Information> add(Information infor)
        {
            listInfor.Add(infor);
            return listInfor;
        }

        public Information details(int id)
        {
            
            return listInfor.First(c => c.Id == id); 
        }

    }
}
