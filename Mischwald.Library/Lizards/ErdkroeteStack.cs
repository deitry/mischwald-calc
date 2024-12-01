using Mischwald.Trees;

namespace Mischwald.Lizards;

public class ErdkroeteStack : IBottom, ICardStack
{
    private Erdkroete? _slot1;
    private Erdkroete? _slot2;
    public T_Tree? Parent { get; set; }

    public bool IsFull => Slot1 != null && Slot2 != null;

    public ErdkroeteStack(int count = 1)
    {
        if (count > 2)
            throw new ArgumentException("Count must be greater than 2", nameof(count));

        for (var i = 0; i < count; i++)
        {
            Add(new Erdkroete());
        }
    }

    public void Add(Erdkroete erdkroete)
    {
        if (Slot1 == null)
        {
            Slot1 = erdkroete;
        }
        else if (Slot2 == null)
        {
            Slot1 = erdkroete;
        }
        else
            throw new Exception("Cannot hold more than two Erdkroete!");
    }

    public Erdkroete? Slot1
    {
        get => _slot1;
        private set
        {
            _slot1 = value;
            if (_slot1 != null)
            {
                _slot1.Parent = Parent;
                _slot1.ParentStack = this;
            }
        }
    }

    public Erdkroete? Slot2
    {
        get => _slot2;
        private set
        {
            _slot2 = value;
            if (_slot2 != null)
            {
                _slot2.Parent = Parent;
                _slot2.ParentStack = this;
            }
        }
    }

    public List<IAnimalOrPlant> UnderlyingCards
    {
        get
        {
            var list = new List<IAnimalOrPlant>();
            if (Slot1 != null) list.Add(Slot1);
            if (Slot2 != null) list.Add(Slot2);
            return list;
        }
    }
}