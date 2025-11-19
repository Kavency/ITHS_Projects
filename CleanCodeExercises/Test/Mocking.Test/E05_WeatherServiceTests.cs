using Moq;
using ÖvningarMockning.Core.Interfaces;

namespace Mocking.Test;

public class E05_WeatherServiceTests
{
    private readonly Mock<IWeatherApiClient> _mockClient;
    private readonly WeatherService _service;

    public E05_WeatherServiceTests()
    {
        _mockClient = new Mock<IWeatherApiClient>();
        _service = new WeatherService(_mockClient.Object);
    }

    [Fact]
    public void GetTodaysTemperature_ProvidesStringForCity_ReturnsTemperature()
    {
        var city = "Skara";
        var date = DateTime.Today;
        var expectedTemp = 19.5d;
        
        _mockClient.Setup(x => x.GetTemperature(city, date)).Returns(expectedTemp);

        var result = _service.GetTodaysTemperature(city);

        Assert.Equal(expectedTemp, result);
        _mockClient.Verify(x => x.GetTemperature(city, date), Times.Once);
    }


    [Fact]
    public void GetTodaysTemperature_HttpFailure_ThrowsHttpRequestException()
    {
        var city = "Skara";
        var date = DateTime.Today;
        
        _mockClient.Setup(x => x.GetTemperature(city, date)).Throws(new HttpRequestException("Mocked failure"));

        Assert.Throws<HttpRequestException>(() => _service.GetTodaysTemperature(city));
    }
}
