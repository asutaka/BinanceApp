using System;

namespace BinanceApp.Model.ENTITY
{
    public class ElementModel : IEquatable<ElementModel>
    {
        public ElementModel()
        {
            Id = 0;
            Value = 0;
        }
        public int Id { get; set; }
        public int Value { get; set; }

        public bool Equals(ElementModel other)
        {
            if (Id == other.Id && Value == other.Value)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            int hashId = Id.GetHashCode();
            int hashValue = Value.GetHashCode();

            return hashId ^ hashValue;
        }
    }
}
