using CleanArchitecture_2025.Domain.Employees;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using TS.Result;

namespace CleanArchitecture_2025.Application.Employees;

public sealed record EmployeeCreateCommand(
    string FirstName,
    string LastName,
    DateOnly BirthOfDate,
    decimal Salary,
    PersonolInformation PersonolInformation,
    Address? Address) : IRequest<Result<string>>;

public sealed class EmployeeCreateCommandValidator : AbstractValidator<EmployeeCreateCommand>
{
    public EmployeeCreateCommandValidator()
    {
        RuleFor(x => x.FirstName).MinimumLength(3).WithMessage("Ad alanı en az 3 karakter olmalıdır");
        RuleFor(x => x.LastName).MinimumLength(3).WithMessage("Soyad alanı en az 3 karakter olmalıdır");
        RuleFor(x => x.PersonolInformation.TCNo)
            .MinimumLength(11).WithMessage("Geçerli bir TC Numarası yazın.")
            .MaximumLength(11).WithMessage("Geçerli bir TC Numarası yazın.");
    }
}

internal sealed class EmployeeCreateCommandHandler(
    IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork) : IRequestHandler<EmployeeCreateCommand, Result<string>>
{
    public async Task<Result<string>> Handle(EmployeeCreateCommand request, CancellationToken cancellationToken)
    {
        var isEmployeeExists = await employeeRepository.AnyAsync(p => p.PersonolInformation.TCNo == request.PersonolInformation.TCNo, cancellationToken);

        if (isEmployeeExists)
        {
            return Result<string>.Failure("Bu TC No daha önce kaydedilmiş");  //unique kontrol
        }

        Employee employee = request.Adapt<Employee>(); //objeden objeye aktarım yapan bir mapleme yapılıyor.mapster ile 

        employeeRepository.Add(employee);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Personel kaydı başarıyla tamamlandı";
    }
}