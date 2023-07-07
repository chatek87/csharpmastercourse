namespace hw_AbstractClasses;

public interface IPolyphonic : IMelodic
{
    void PlayChord(List<int> noteValues);
}