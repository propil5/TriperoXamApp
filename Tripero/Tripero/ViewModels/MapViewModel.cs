﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace Tripero.ViewModels
{
    public class MapViewModel<T> : BaseViewModel
    {
        public static readonly Position NullPosition = new Position(0, 0);

        public MapViewModel()
        {
            Title = "Map";
            //Icon = "map.png";
        }

        //public List<Pin> LoadPins()
        //{
        //    ExecuteLoadModelsCommand();

        //    var pins = Models.Select(model =>
        //    {
        //        var item = (IContact)model;
        //        var address = item.Address ?? item.ShippingAddress ?? item.BillingAddress;

        //        var position = address != null ? new Position(address.Latitude, address.Longitude) : NullPosition;
        //        var pin = new Pin
        //        {
        //            Type = PinType.Place,
        //            Position = position,
        //            Label = item.ToString(),
        //            Address = address.ToString()
        //        };
        //        return pin;
        //    }).ToList();

        //    return pins; ;
    }
}

