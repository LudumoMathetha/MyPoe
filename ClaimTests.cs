using Xunit;
using CMCS.Models;

namespace CMCS.Tests;

public class ClaimTests
{
    [Fact]
    public void Amount_Computed_Correctly()
    {
        var claim = new Claim { HoursWorked = 5, HourlyRate = 200.0m };
        Assert.Equal(1000.0m, claim.Amount);
    }
}
