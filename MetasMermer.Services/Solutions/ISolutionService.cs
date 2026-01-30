namespace MetasMermer.Services.Solutions;

public interface ISolutionService
{
    Task<SolutionDto> GetByIdAsync(int id);
    Task<SolutionDto> Update(UpdateSolutionDto updateSolutionDto);
}
