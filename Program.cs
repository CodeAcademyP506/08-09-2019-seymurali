class Program
    {
        static void Main(string[] args)
        {
            Category ickiler = new Category("İçkilər");
            Category meyveler = new Category("Meyvələr");

            List<Person> customer = new List<Person>() {
                new Person(1,25,"Nurlan"),
                new Person(2,20,"Ramin"),
                new Person(3,29,"Kamal"),
                new Person(4,30,"Emin"),
                new Person(5,15,"Seymur"),
            };

            List<Product> products = new List<Product>()
            {
                new Product(1,"Coca-cola",2,ickiler),
                new Product(2,"Fanta",2,ickiler),
                new Product(3,"Sprite",3,ickiler),
                new Product(4,"Alma",3,meyveler),
                new Product(5,"Heyva",2,meyveler),
                new Product(6,"Nar",5,meyveler)            
            };

            List<OrderHistory> orderHistories = new List<OrderHistory>()
            {
                new OrderHistory(1,1,3,4),
                new OrderHistory(2,2,2,5),
                new OrderHistory(3,2,5,3),
                new OrderHistory(4,3,5,3),
                new OrderHistory(5,4,6,6),
                new OrderHistory(6,5,1,1),
                new OrderHistory(7,5,1,8)
            };
           

        }
    }

    class Person
    {
        public Person(int i,int a, string n)
        {
            Age = a;
            Name = n;
            Id = i;
        }
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public int Test { get; set; }
    }

    class Category
    {
        public Category(string n)
        {
            Name = n;
        }
        public string Name { get; set; }
    }

    class Product
    {
        public Product(int i, string n, double p, Category c)
        {
            Id = i;
            Name = n;
            Price = p;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
    }

    class OrderHistory
    {
        public OrderHistory(int i, int cid, int pid, int cnt)
        {
            Id = i;
            CustomerId = cid;
            ProductId = pid;
            Count = cnt;
        }
        public int Id { get; set; }
        public int CustomerId {get;set;}
        public int ProductId {get; set; }
        public int Count { get; set; }
    }
