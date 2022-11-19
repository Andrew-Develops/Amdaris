
WeatherStation weatherStation = new WeatherStation();

NewsAgency agency1 = new NewsAgency("John Agency");
weatherStation.Attach(agency1);

NewsAgency agency2 = new NewsAgency("Mike Agency");
weatherStation.Attach(agency1);


weatherStation.Temperature = 25.7f;
weatherStation.Temperature = 28.1f;
weatherStation.Temperature = 20.2f;

Console.ReadLine();

interface ISubject
{
	void Attach(IObserver observer);
	void Notify();
}
interface IObserver
{
	void Update(ISubject subject);
}

class WeatherStation : ISubject
{
	private List<IObserver> _observers;
	private float _temperature;

	public float Temperature
	{
		get { return _temperature; }
		set
		{
			_temperature = value;
			Notify();
		}
	}

	public WeatherStation()
	{
		_observers = new List<IObserver>();
	}

	public void Attach(IObserver observer)
	{
		_observers.Add(observer);
	}
	public void Notify()
	{
		_observers.ForEach(x => { x.Update(this); });
	}
}

class NewsAgency : IObserver
{
	public string AgencyName { get; set; }
	public NewsAgency(string name)
	{
		AgencyName = name;
	}
	public void Update(ISubject subject)
	{
		if (subject is WeatherStation weatherStation)
		{
			Console.WriteLine("News Agency {0} reports that the temperature is {1}", AgencyName, weatherStation.Temperature);
		}
	}

	
	
	


}