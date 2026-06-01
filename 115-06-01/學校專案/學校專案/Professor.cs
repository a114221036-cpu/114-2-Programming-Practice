using System;

namespace 學校專案
{
    /// <summary>
    /// 教師基底類別（例如: Professor）
    /// - 屬性：教師編號、教師姓名、基本薪資（限制 80,000 ~ 100,000）
    /// - 方法：計算實領薪資（基本薪資扣除 6% 稅金）
    /// </summary>
    public class Professor
    {
        private decimal _baseSalary;

        /// <summary>
        /// 教師編號
        /// </summary>
        public string TeacherId { get; set; }

        /// <summary>
        /// 教師姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 基本薪資（範圍 80,000 ～ 100,000）
        /// 若設定值不在範圍內會丟出例外
        /// </summary>
        public decimal BaseSalary
        {
            get => _baseSalary;
            set
            {
                if (value < 80000m || value > 100000m)
                {
                    throw new ArgumentOutOfRangeException(nameof(BaseSalary), "基本薪資必須介於 80,000 至 100,000 之間。");
                }

                _baseSalary = value;
            }
        }

        public Professor() { }

        public Professor(string teacherId, string name, decimal baseSalary)
        {
            TeacherId = teacherId;
            Name = name;
            BaseSalary = baseSalary;
        }

        /// <summary>
        /// 計算實領薪資（基本薪資扣除 6% 稅金）
        /// </summary>
        /// <returns>扣稅後的實領金額</returns>
        public decimal CalculateNetSalary()
        {
            const decimal taxRate = 0.06m;
            return Math.Round(BaseSalary * (1 - taxRate), 2);
        }
    }
}