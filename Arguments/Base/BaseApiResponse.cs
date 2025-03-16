namespace Arguments.Base;

public class BaseApiResponse<TTypeResult, TTypeError>
{
    public TTypeResult? Result { get; set; }

    public TTypeError? Error { get; set; }
}
