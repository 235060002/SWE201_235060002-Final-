public class Member
{
    public int MemberId { get; set; }
    public string FullName { get; set; }

    public Member(int memberId, string fullName)
    {
        MemberId = memberId;
        FullName = fullName;
    }
}
