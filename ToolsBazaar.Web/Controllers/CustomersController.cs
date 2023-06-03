using Microsoft.AspNetCore.Mvc;
using ToolsBazaar.Domain.CustomerAggregate;

namespace ToolsBazaar.Web.Controllers;

public record CustomerDto(string Name);

[ApiController]
[Route("[controller]")]
public class CustomersController : ControllerBase
{
    private readonly ICustomerRepository _customerRepository;
    private readonly ILogger<CustomersController> _logger;

    public CustomersController(ILogger<CustomersController> logger, ICustomerRepository customerRepository)
    {
        _logger = logger;
        _customerRepository = customerRepository;
    }

    public CustomersController(ICustomerRepository customerRepository, ILogger logger)
    {
        CustomerRepository = customerRepository;
        Logger = logger;
    }

    public ICustomerRepository CustomerRepository { get; }
    public ILogger Logger { get; }

    [HttpPut("{customerId:int}")]
    public void UpdateCustomerName(int customerId, [FromRoute] CustomerDto dto)
    {
        _logger.LogInformation($"Updating customer #{customerId} name...");

        _customerRepository.UpdateCustomerName(customerId, dto.Name);
    }
}