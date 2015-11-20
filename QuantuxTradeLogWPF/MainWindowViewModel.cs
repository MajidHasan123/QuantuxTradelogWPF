using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuantuxTradeLogWPF;
using Quantux.MVVM;
using System.Collections.ObjectModel;
using System.Windows.Input;


namespace QuantuxTradeLogWPF
{
    class MainWindowViewModel : ObservableObject
    {

        private ObservableCollection<TradelogData> dataItems;
        public ObservableCollection<TradelogData> DataItems
        {
            get { return dataItems; }
            set 
            {
                dataItems = value; 
                OnPropertyChanged("DataItems"); 
            }
        }

        public MainWindowViewModel() 
        {
            DataItems = new ObservableCollection<TradelogData>()
         {
             new TradelogData(){RMult="BTO",Ticks="LMT",Points="5555",AveragePrice="555",Trade="E"},
             new TradelogData(){RMult="BTO",Ticks="LMT",Points="7777",AveragePrice="77",Trade="T"},
             new TradelogData(){RMult="BTO",Ticks="GMT",Points="998",AveragePrice="967",Trade="E"},
             new TradelogData(){RMult="BTO",Ticks="LMT",Points="5555",AveragePrice="555",Trade="E"},
             new TradelogData(){RMult="BTO",Ticks="LMT",Points="7777",AveragePrice="77",Trade="T"},
             new TradelogData(){RMult="BTO",Ticks="GMT",Points="998",AveragePrice="967",Trade="E"},
             new TradelogData(){RMult="BTO",Ticks="LMT",Points="5555",AveragePrice="555",Trade="E"},
             new TradelogData(){RMult="BTO",Ticks="LMT",Points="7777",AveragePrice="77",Trade="T"},
             new TradelogData(){RMult="BTO",Ticks="GMT",Points="998",AveragePrice="967",Trade="E"},
             new TradelogData(){RMult="BTO",Ticks="LMT",Points="5555",AveragePrice="555",Trade="E"},
             new TradelogData(){RMult="BTO",Ticks="LMT",Points="7777",AveragePrice="77",Trade="T"},
             new TradelogData(){RMult="BTO",Ticks="GMT",Points="998",AveragePrice="967",Trade="E"},
         };

        }

        #region Properties

        private string _rMultInRMult;
        public string RMultInRMult
        {
            get { return _rMultInRMult; }
            set
            {
                _rMultInRMult = value;
                RaisePropertyChanged("RMultInRMult");
            }
        }

        private string _ticksInRMult;
        public string TicksInRMult
        {
            get { return _ticksInRMult; }
            set
            {
                _ticksInRMult = value;
                RaisePropertyChanged("TicksInRMult");
            }
        }

        private string _pointsInRMult;
        public string PointsInRMult
        {
            get { return _pointsInRMult; }
            set
            {
                _pointsInRMult = value;
                RaisePropertyChanged("PointsInRMult");
            }
        }

        private string _rMultInMFE;
        public string RMultInMFE
        {
            get { return _rMultInMFE; }
            set
            {
                _rMultInMFE = value;
                RaisePropertyChanged("RMultInMFE");
            }
        }

        private string _ticksInMFE;
        public string TicksInMFE
        {
            get { return _ticksInMFE; }
            set
            {
                _ticksInMFE = value;
                RaisePropertyChanged("TicksInMFE");
            }
        }

        private string _pointsInMFE;
        public string PointsInMFE
        {
            get { return _pointsInMFE; }
            set
            {
                _pointsInMFE = value;
                RaisePropertyChanged("PointsInMFE");
            }
        }

        private string _rmultInMAE;
        public string RmultInMAE
        {
            get { return _rmultInMAE; }
            set
            {
                _rmultInMAE = value;
                RaisePropertyChanged("RmultInMAE");
            }
        }

        private string _ticksInMAE;
        public string TicksInMAE
        {
            get { return _ticksInMAE; }
            set
            {
                _ticksInMAE = value;
                RaisePropertyChanged("TicksInMAE");
            }
        }

        private string _pointsInMAE;
        public string PointsInMAE
        {
            get { return _pointsInMAE; }
            set
            {
                _pointsInMAE = value;
                RaisePropertyChanged("PointsInMAE");
            }
        }

        private string _rMultInEAR;
        public string RMultInEAR
        {
            get { return _rMultInEAR; }
            set
            {
                _rMultInEAR = value;
                RaisePropertyChanged("RMultInEAR");
            }
        }

        private string _ticksInEAR;
        public string TicksInEAR
        {
            get { return _ticksInEAR; }
            set
            {
                _ticksInEAR = value;
                RaisePropertyChanged("TicksInEAR");
            }
        }

        private string _pointsInEAR;
        public string PointsInEAR
        {
            get { return _pointsInEAR; }
            set
            {
                _pointsInEAR = value;
                RaisePropertyChanged("PointsInEAR");
            }
        }

        private string _aVBtoPrice = "Av. BTO Price";
        public string AVBtoPrice
        {
            get { return _aVBtoPrice; }
            set
            {
                _aVBtoPrice = value;
                RaisePropertyChanged("AVBtoPrice");
            }
        }

        private string _realizedPnl = "Realized PnL:";
        public string RealizedPnl
        {
            get { return _realizedPnl; }
            set
            {
                _realizedPnl = value;
                RaisePropertyChanged("RealizedPnl");
            }
        }

        private string _avgSTCPrice = "@ Av. STC Price";
        public string AvgSTCPrice
        {
            get { return _avgSTCPrice; }
            set
            {
                _avgSTCPrice = value;
                RaisePropertyChanged("AvgSTCPrice");
            }
        }

        private string _unRealizedPnl = "UnRealized PnL:";
        public string UnRealizedPnl
        {
            get { return _unRealizedPnl; }
            set { _unRealizedPnl = value; RaisePropertyChanged("UnRealizedPnl"); }
        }

        private string _sTCMKTBID = "STC @ MKT (Bid)";
        public string STCMKTBID
        {
            get { return _sTCMKTBID; }
            set { _sTCMKTBID = value; RaisePropertyChanged("STCMKTBID"); }
        }

        private double _realizedPnlPnl;
        public double RealizedPnlPnl
        {
            get { return _realizedPnlPnl; }
            set { _realizedPnlPnl = value; RaisePropertyChanged("RealizedPnlPnl"); }
        }

        private double _realizedPnlUnits;
        public double RealizedPnlUnits
        {
            get { return _realizedPnlUnits; }
            set { _realizedPnlUnits = value; RaisePropertyChanged("RealizedPnlUnits"); }
        }

        private double _realizedPnlEqu;
        public double RealizedPnlEqu
        {
            get { return _realizedPnlEqu; }
            set { _realizedPnlEqu = value; RaisePropertyChanged("RealizedPnlEqu"); }
        }

        private double _unRealizedPnlPnl;
        public double UnRealizedPnlPnl
        {
            get { return _unRealizedPnlPnl; }
            set { _unRealizedPnlPnl = value; RaisePropertyChanged("UnRealizedPnlPnl"); }
        }

        private double _unRealizedPnlUnints;
        public double UnRealizedPnlUnints
        {
            get { return _unRealizedPnlUnints; }
            set { _unRealizedPnlUnints = value; RaisePropertyChanged("UnRealizedPnlUnints"); }
        }

        private double _unRealizedPnlEqu;
        public double UnRealizedPnlEqu
        {
            get { return _unRealizedPnlEqu; }
            set { _unRealizedPnlEqu = value; RaisePropertyChanged("UnRealizedPnlEqu"); }
        }

        private double _AvgEntryPrice;
        public double AvgEntryPrice
        {
            get { return _AvgEntryPrice; }
            set { _AvgEntryPrice = value; RaisePropertyChanged("AvgEntryPrice"); }
        }

        private double _avgExitPrice;
        public double AvgExitPrice
        {
            get { return _avgExitPrice; }
            set { _avgExitPrice = value; RaisePropertyChanged("AvgExitPrice"); }
        }

        private double _currentMKTPrice;
        public double CurrentMKTPrice
        {
            get { return _currentMKTPrice; }
            set { _currentMKTPrice = value; RaisePropertyChanged("CurrentMKTPrice"); }
        }

        private double _totalPnl;
        public double TotalPnl
        {
            get { return _totalPnl; }
            set { _totalPnl = value; RaisePropertyChanged("TotalPnl"); }
        }

        private double _totalUnits;
        public double TotalUnits
        {
            get { return _totalUnits; }
            set { _totalUnits = value; RaisePropertyChanged("TotalUnits"); }
        }

        private double _totalEqu;
        public double TotalEqu
        {
            get { return _totalEqu; }
            set { _totalEqu = value; RaisePropertyChanged("TotalEqu"); }
        }




        #endregion

        #region Commands
        #endregion
    }

    public class TradelogData
    {
        public string RMult { get; set; }
        public string Ticks { get; set; }
        public string Points { get; set; }
        public string AveragePrice { get; set; }
        public string Trade { get; set; }

    }
}
