namespace Lesson04_ViewModel.Models
{
    public class DataLocal
    {

        public static List<People> _peoples = new List<People>(){

            new People(){Id = 0 ,Name="Cong phu panda 1" ,
                Email="gautruc123@gmail" ,Phone="12345678" ,
                Address="Hà Nội" , Avatar="img/1.jpeg",
                Birthday=Convert.ToDateTime("2002/05/05"),
                Bio="Duong Duong 1",Gender=1},
            new People(){Id = 1 ,Name="Cong phu panda 1" ,
                Email="gautruc123@gmail" ,Phone="12345678" ,
                Address="Hà Nội" , Avatar="img/2.jpeg",
                Birthday=Convert.ToDateTime("2002/01/05"),
                Bio="Duong Duong 2",Gender=0},
            new People(){Id = 2 ,Name="Cong phu panda 1" ,
                Email="gautruc123@gmail" ,Phone="12345678" ,
                Address="Hà Nội" , Avatar="img/3.jpeg",
                Birthday=Convert.ToDateTime("2002/02/05"),
                Bio="Duong Duong 3",Gender=1},
            new People(){Id = 3 ,Name="Cong phu panda 1" ,
                Email="gautruc123@gmail" ,Phone="12345678" ,
                Address="Hà Nội" , Avatar="img/4.jpeg",
                Birthday=Convert.ToDateTime("2002/03/05"),
                Bio="Duong Duong 4",Gender=0},
            new People(){Id = 4 ,Name="Cong phu panda 1" ,
                Email="gautruc123@gmail" ,Phone="12345678" ,
                Address="Hà Nội" , Avatar="img/5.jpeg",
                Birthday=Convert.ToDateTime("2002/04/05"),
                Bio="Duong Duong 5",Gender=1}
        };

        public static List<People> GetPeoples()
        {
            return _peoples;
        }
        public static People? GetPeopleById(int Id)
        {
            var people = _peoples.FirstOrDefault(x => x.Id == Id);
            return people;
        }
    }
}
