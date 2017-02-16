namespace myRpg
{
    interface IWeapon
    {
        int Damage { get; }
        bool IsEquipped { get; set; }
    }
}