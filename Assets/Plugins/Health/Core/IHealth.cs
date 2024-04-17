using UniRx;

namespace Plugins.Health.Core
{
    public interface IHealth
    {
        public IReadOnlyReactiveProperty<float> Value { get; }

        public IReadOnlyReactiveProperty<float> MaxValue { get; }

        public IReadOnlyReactiveProperty<float> FillAmount { get; }

        public IReadOnlyReactiveProperty<bool> IsFull { get; }

        public IReadOnlyReactiveProperty<bool> IsDeath { get; }

        public Subject<float> OnDamaged { get; }

        public Subject<float> OnHealed { get; }

        public void SetValue(float health);

        public void SetMaxValue(float maxValue);

        public void Heal(float amount);

        public void TakeDamage(float damage);

        public void Kill();

        public void Restore();
    }
}