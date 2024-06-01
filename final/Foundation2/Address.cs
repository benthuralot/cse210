public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;
    private bool _isAmerican;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
        if (_country == "USA")
        {
            _isAmerican = true;
        }
        else
        {
            _isAmerican = false;
        }
        
    }
    public string Display()
    {
        if (_isAmerican == true)
        {
            return $"{_street}\n{_city}, {_stateProvince}, USA";
        }
        else
        {
            return $"{_street}\n{_city} {_stateProvince}\n{_country}";
        }
        
    }
    public bool isAmerican()
    {
        return _isAmerican;
    }
}