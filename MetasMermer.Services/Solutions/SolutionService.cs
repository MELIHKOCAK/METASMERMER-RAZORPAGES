using Mapster;
using MetasMermer.Repositories;
using MetasMermer.Repositories.EFCORE.Solutions;

namespace MetasMermer.Services.Solutions;

public class SolutionService(IGenericRepository<Solution> _repository, IUnitOfWork _unitOfWork) : ISolutionService
{
    public async Task<SolutionDto> GetByIdAsync(int id)
    {
        var solution = await _repository.GetByIdAsync(id);

        if (solution is null)
            return new SolutionDto { Title = "Null", Description = "Null"};

        return solution.Adapt<SolutionDto>();
    }

    public async Task<SolutionDto> Update(UpdateSolutionDto updateSolutionDto)
    {
        var solution = await _repository.GetByIdAsync(updateSolutionDto.Id);

        if (solution is null)
            return new SolutionDto { Title = "Null", Description = "Null" };

        solution.Description = updateSolutionDto.Description;
        solution.Title = updateSolutionDto.Title;

        _repository.Update(solution);

        await _unitOfWork.SaveChangeAsync();

        return solution.Adapt<SolutionDto>();
    }
}
