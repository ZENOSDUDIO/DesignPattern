using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    #region Ver 3
    //public enum ChargeType
    //{
    //    NoDiscount = 0,
    //    With20Off = 1,
    //    With30Off = 2,
    //    With50Off = 3,
    //    Return200When500 = 4
    //}

    //public abstract class CashSuper
    //{
    //    public abstract double AcceptCash(double money);
    //}

    //public class CashNormal : CashSuper
    //{
    //    public override double AcceptCash(double money)
    //    {
    //        return money;
    //    }
    //}

    //public class CashDiscount : CashSuper
    //{
    //    public double DiscountRate { get; set; }

    //    public CashDiscount(double discountRate)
    //    {
    //        DiscountRate = discountRate;
    //    }

    //    public override double AcceptCash(double money)
    //    {
    //        return money * DiscountRate;
    //    }
    //}

    //public class CashReturn : CashSuper
    //{
    //    public double MoneyCondition { get; set; }
    //    public double MoneyReturn { get; set; }

    //    public CashReturn(double moneyCondition, double moneyReturn)
    //    {
    //        MoneyCondition = moneyCondition;
    //        MoneyReturn = moneyReturn;
    //    }

    //    public override double AcceptCash(double money)
    //    {
    //        return money >= MoneyCondition ? money - Math.Floor(money / MoneyCondition) * MoneyReturn : money;
    //    }
    //}

    //public class CashFactory
    //{
    //    public static CashSuper CreateCashAccept(ChargeType type)
    //    {
    //        CashSuper cs = null;

    //        switch (type)
    //        {
    //            case ChargeType.NoDiscount:
    //                return cs = new CashNormal();
    //            case ChargeType.With20Off:
    //                return cs = new CashDiscount(0.8);
    //            case ChargeType.With30Off:
    //                return cs = new CashDiscount(0.7);
    //            case ChargeType.With50Off:
    //                return cs = new CashDiscount(0.5);
    //            case ChargeType.Return200When500:
    //                return cs = new CashReturn(500, 200);
    //        }

    //        return cs;
    //    }
    //}
    #endregion

    #region Ver 4 : Ver3
    //public class CashContext
    //{
    //    private CashSuper cs;

    //    public CashContext(CashSuper cs)
    //    {
    //        this.cs = cs;
    //    }

    //    public double GetResult(double money)
    //    {
    //        return cs.AcceptCash(money);
    //    }
    //}
    #endregion

    #region Ver 5 : Ver 3
    //public class CashContext
    //{
    //    private CashSuper cs;

    //    public CashContext(ChargeType type)
    //    {
    //        switch (type)
    //        {
    //            case ChargeType.NoDiscount:
    //                cs = new CashNormal();
    //                break;
    //            case ChargeType.With20Off:
    //                cs = new CashDiscount(0.8);
    //                break;
    //            case ChargeType.With30Off:
    //                cs = new CashDiscount(0.7);
    //                break;
    //            case ChargeType.With50Off:
    //                cs = new CashDiscount(0.5);
    //                break;
    //            case ChargeType.Return200When500:
    //                cs = new CashReturn(500, 200);
    //                break;
    //        }
    //    }

    //    public double GetResult(double money)
    //    {
    //        return cs.AcceptCash(money);
    //    }
    //}
    #endregion
}
