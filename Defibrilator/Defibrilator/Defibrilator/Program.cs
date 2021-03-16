using System;
class Solution
{
    static void Main(string[] args)
    {
        float LON = float.Parse(Console.ReadLine());
        float LAT = float.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        DEFIB[] defibs = new DEFIB[N];
        for (int i = 0; i < N; i++)
            defibs[i] = new DEFIB(Console.ReadLine());
        DEFIB myDefib = defibs[0];

        foreach (var a in defibs)
            if (myDefib.distance(LAT, LON) > a.distance(LAT, LON))
                myDefib = a;

        Console.WriteLine(myDefib.name);
    }
    public struct DEFIB {
        public int index;
        public string name;
        public string adress;
        public string phoneNum;
        public float Longitude;
        public float Latitude;
        public DEFIB(string s)
        {
            string[] ssd = s.Split(';');
            index = int.Parse(ssd[0]);
            name = ssd[1];
            adress = ssd[2];
            phoneNum = ssd[3];
            Longitude = float.Parse(ssd[4]);
            Latitude = float.Parse(ssd[5]);
        }
        public float distance(float latitude, float longitude)
        {
            float x = (float)((Longitude - longitude) * Math.Cos((latitude + Latitude) / 2));
            float y = Latitude - latitude;
            return (float)Math.Sqrt(x * x + y * y) * 6371;
        }
        public override string ToString()
        {
            return $"index:{index} \n " +
                $"name:{name} | adress is '{adress}' \n " +
                $"num:{phoneNum} \n " +
                $"coords: {Longitude} {Latitude}";
        }
    }

}