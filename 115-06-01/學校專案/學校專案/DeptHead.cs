using System;

namespace 學校專案
{
    /// <summary>
    /// 系主任類別（繼承自 Professor，例如: Dept_Head）
    /// - 額外屬性：主任加給（範圍 20,000 ~ 50,000）
    /// - 額外方法：加總基本薪資與加給
    /// </summary>
    public class DeptHead : Professor
    {
        private decimal _allowance;

        /// <summary>
        /// 主任加給（範圍 20,000 ～ 50,000）
        /// </summary>
        public decimal Allowance
        {
            get => _allowance;
            set
            {
                if (value < 20000m || value > 50000m)
                {
                    throw new ArgumentOutOfRangeException(nameof(Allowance), "主任加給必須介於 20,000 至 50,000 之間。");
                }

                _allowance = value;
            }
        }

        public DeptHead() { }

        public DeptHead(string teacherId, string name, decimal baseSalary, decimal allowance)
            : base(teacherId, name, baseSalary)
        {
            Allowance = allowance;
        }

        /// <summary>
        /// 加總基本薪資與加給（不含扣稅）
        /// </summary>
        /// <returns>基本薪資 + 加給</returns>
        public decimal TotalSalary()
        {
            return BaseSalary + Allowance;
        }
    }
}