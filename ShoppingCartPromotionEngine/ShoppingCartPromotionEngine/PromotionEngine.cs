using ShoppingCartPromotionEngine.App_Data;
using ShoppingCartPromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns;
using System.Text.RegularExpressions;

namespace ShoppingCartPromotionEngine
{
    public class PromotionEngine : IPromotionEngine
    {
        DataAccess dataAccessObj;
        Regex regex;

        public decimal ApplyPromotionCode(List<CartItemsDTO> cartItemsDtoObj,List<PromotionDTO> promotionCodes)
        {
            decimal totalBillAmount = 0;
            //var promotionCodes = GetActivePromotionCode();
            List<CartItemsDTO> combinationPromoSKUs = new List<CartItemsDTO>(); ;
            if (cartItemsDtoObj != null && cartItemsDtoObj.Count > 0)
            {
                foreach (var item in cartItemsDtoObj)
                {
                    for (int i = 0; i <= promotionCodes.Count - 1; i++)
                    {
                        if (promotionCodes[i].PromotionCode.Contains(item.SKUId))
                        {
                            //3 of A's for 130
                            //2 of B's for 45
                            if (promotionCodes[i].PromotionCode.Contains(PatternHelper._OF) && promotionCodes[i].PromotionCode.Contains(PatternHelper._FOR))
                            {
                                //regex = new Regex(PatternHelper._NUMBER_REGEX);
                                var match = Regex.Matches(promotionCodes[i].PromotionCode, PatternHelper._NUMBER_REGEX).OfType<Match>().Select(m => int.Parse(m.Value)).ToArray();
                                //MatchCollection match = regex.Match( (code.PromotionCode);
                                if (match != null && item.Quantity >= Convert.ToInt32(match[0]))
                                {
                                    int outParam = 0;
                                    var output = Math.DivRem(item.Quantity, Convert.ToInt32(match[0]), out outParam);
                                    totalBillAmount += output * Convert.ToInt32(match[1]) + outParam * item.UnitPrice;
                                    break;
                                }
                            }
                            //C & D for 30
                            //A & B & C for 80
                            else if (promotionCodes[i].PromotionCode.Contains(PatternHelper._AND)) //code.PromotionCode.Contains(PatternHelper._FOR)
                            {
                                if (combinationPromoSKUs.Count > 0)
                                {
                                    var match = Regex.Matches(promotionCodes[i].PromotionCode, PatternHelper._AND);
                                    if (match.Count > 0 && match.Count == 1)
                                    {
                                        var matchN = Regex.Matches(promotionCodes[i].PromotionCode, PatternHelper._NUMBER_REGEX).OfType<Match>().Select(m => int.Parse(m.Value)).ToArray();
                                        totalBillAmount += Convert.ToInt32(matchN[0]);
                                        combinationPromoSKUs.Clear();
                                        break;
                                    }
                                    else if (match.Count > 1 && match.Count.Equals(combinationPromoSKUs.Count))
                                    {
                                        var matchN1 = Regex.Matches(promotionCodes[i].PromotionCode, PatternHelper._NUMBER_REGEX).OfType<Match>().Select(m => int.Parse(m.Value)).ToArray();
                                        totalBillAmount += Convert.ToInt32(matchN1[0]);
                                        combinationPromoSKUs.Clear();
                                        break;
                                    }
                                    else
                                        combinationPromoSKUs.Add(item);
                                }
                                else
                                    combinationPromoSKUs.Add(item);
                            }
                            //10% of A
                            else if (promotionCodes[i].PromotionCode.Contains(PatternHelper._PERCENTAGE))
                            {
                                MatchCollection match = regex.Matches(promotionCodes[i].PromotionCode);
                                if (match != null && match.Count > 0)
                                {
                                    var totalVal = item.UnitPrice * item.Quantity;
                                    var value = (totalVal) - (totalVal * (Convert.ToInt32(match[0]) / 100));
                                    totalBillAmount += value;
                                    break;
                                }
                            }
                        }
                        else if (promotionCodes.Count-1 == i)
                        {
                            totalBillAmount += (item.UnitPrice * item.Quantity);
                            break;
                        }
                    }                    
                }
                if (combinationPromoSKUs != null && combinationPromoSKUs.Count > 0)
                {
                    var sumVal = combinationPromoSKUs.Sum(p => p.Quantity * p.UnitPrice);
                    totalBillAmount += sumVal;
                }
            }
            return totalBillAmount;
        }        

        public List<PromotionDTO> GetActivePromotionCode()
        {
            dataAccessObj = new DataAccess();
            return dataAccessObj.GetActivePromotions();
        }
    }
}
