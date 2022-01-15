using System;
using System.Collections.Generic; 

namespace VS_CODE_DAY1
{
    class Program
    {
       static List<Member> members = new List<Member>
        {
            new Member
            {
                FirstName = "Phuong",
                LastName = "Nguyen Nam",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 1, 22),
                PhoneNumber = "",
                BirthPlace = "Phu Tho",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Nam",
                LastName = "Nguyen Thanh",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 1, 20),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Son",
                LastName = "Do Hong",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 11, 6),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Huy",
                LastName = "Nguyen Duc",
                Gender = "Male",
                DateOfBirth = new DateTime(1996, 1, 26),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Hoang",
                LastName = "Phuong Viet",
                Gender = "Male",
                DateOfBirth = new DateTime(1999, 2, 5),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Long",
                LastName = "Lai Quoc",
                Gender = "Male",
                DateOfBirth = new DateTime(1997, 5, 30),
                PhoneNumber = "",
                BirthPlace = "Bac Giang",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Thanh",
                LastName = "Tran Chi",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 9, 18),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            }
        };

        static void Main(string[] args)
        {
            // 1.return a list of members who is male
            //var maleMembers = GetMaleMembers();
            //Printdata (maleMembers);
            // 2.Find oldest member
            //var oldest = GetOldestMember();
            //Printdata(new List<Member> {oldest});
            // 3.Member full name
            //var fullnames = GetFullNames();
            //foreach(var fullname in fullnames)
            //{
            //    Console.WriteLine(fullname);
            //}
            // 4.Split member by year
            //var results = SplitMembersByBirthYear();
           //Printdata(results.Item1); 
            //Console.WriteLine("-----------------------");
            //Printdata(results.Item2);  
            //Console.WriteLine("-----------------------");
           // Printdata(results.Item3);  
           //5. Get HaNoi base
            var hanoiMembers = GetHaNoiMembers();
            Printdata (hanoiMembers);
        }
        static void Printdata(List<Member> data)
        {
            var index = 0;
            foreach (var item in data)
            {
                ++index;
                Console.WriteLine($"{index}. {item.LastName} {item.FirstName} - {item.DateOfBirth.ToString("dd/MM/yyyy")}-[{item.Age}]");
            } 
        }
        static List<Member> GetMaleMembers()
    
        {
            var result = new List<Member>();
            foreach (var member in members)
            {
                if (member.Gender == "Male")
                {
                    result.Add(member);
                }
            }
            return result;
        }
        static Member GetOldestMember()
        {
            var maxAge = members[0].Age;
            var maxAgeIndex = 0;
            for (var i=1;i<members.Count;i++)
            {
                var member = members[i];
                if (member.Age > maxAge)
                {
                    maxAge = member.Age;
                    maxAgeIndex = i;
                }
            }
            return members[maxAgeIndex ];
        }
        static List<string> GetFullNames()
        {
            var result = new List<string>();
            foreach (var member in members)
            {
                result.Add($"{member.LastName} {member.FirstName}");
            }
            return result;
        }
        static Tuple<List<Member>, List<Member>,List<Member>> SplitMembersByBirthYear()
        {
            var list1 = new List<Member>();
            var list2 = new List<Member>();
            var list3 = new List<Member>();
            foreach (var member in members)
            {
                var Birthyear = member.DateOfBirth.Year;
                switch (Birthyear)
                {
                    case 2000: 
                        list1.Add(member);
                        break;
                    case <2000:
                        list2.Add(member);
                        break;
                    case >2000:
                        list3.Add(member);
                        break;

                }
            }
            return Tuple.Create(list1,list2,list3);
        }
        static List<Member> GetHaNoiMembers()
    
        {
            var result = new List<Member>();
            foreach (var member in members)
            {
                if (member.BirthPlace == "Ha Noi")
                {
                    result.Add(member);
                }
            }
            return result;
        }
    }
}
