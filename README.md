# Xamarin.Forms CollectionView Grouped Items Reordering

## Background

This repository contains Xamarin.Forms demo, implementing Xamarin.Forms CollectionView Grouped Items reordering. This demo takes advantage of new Xamarin.Forms 5.0 drag and drop gestures and doesn't use native code, no extra renderers or effects, no platform specific configuration, just old good MVVM. Once items are reordered, the view model state instantly reflects the new order.

<img src='Images/xamarinforms-collectionview-groupeditems-reordering.gif'>


## Implementation

The reordering logic is as simple as removing items from the source collection and moving the item to the target collection. The solution is cross-platform and works well on iOS, Android and UWP.

## Animations

Animations can look jittery but only because the demo is a very simple implementation and you can fully customize the look and feel ot the items being dragged from, over and to.

## Dependencies

- Xamarin.Forms (CollectionView, Drap&Drop gesture recognizers)
- Xamarin.CommunityToolkit (bindings and convertors)
- Xamarin.Essentials (optional but highly recommended)
