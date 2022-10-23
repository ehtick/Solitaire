﻿ 
using Avalonia.Controls; 
 
namespace SolitaireAvalonia.Views;

/// <summary>
/// Interaction logic for KlondikeSolitaireView.xaml
/// </summary>
public partial class KlondikeSolitaireView : UserControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KlondikeSolitaireView"/> class.
    /// </summary>
    public KlondikeSolitaireView()
    {
        InitializeComponent();
        
        // //  Wire up the drag and drop host.
        // dragAndDropHost.DragAndDropStart += new DragAndDropDelegate(Instance_DragAndDropStart);
        // dragAndDropHost.DragAndDropContinue += new DragAndDropDelegate(Instance_DragAndDropContinue);
        // dragAndDropHost.DragAndDropEnd += new DragAndDropDelegate(Instance_DragAndDropEnd);
    }
    //
    // void Instance_DragAndDropEnd(object sender, DragAndDropEventArgs args)
    // {
    //     //  We've put cards temporarily in the drag stack, put them in the 
    //     //  source stack again.                
    //     ItemsControl sourceStack = args.DragSource as ItemsControl;
    //     foreach (var dragCard in draggingCards)
    //         ((ObservableCollection<PlayingCardViewModel>)((ItemsControl)args.DragSource).Items).Add(dragCard);
    //
    //     //  If we have a drop target, move the card.
    //     if (args.DropTarget != null)
    //     {
    //         //  Move the card.
    //         ViewModel.MoveCard(
    //             (ObservableCollection<PlayingCardViewModel>)((ItemsControl)args.DragSource).Items,
    //             (ObservableCollection<PlayingCardViewModel>)((ItemsControl)args.DropTarget).Items,
    //             (PlayingCardViewModel)args.DragData, false);
    //     }
    // }
    //
    // void Instance_DragAndDropContinue(object sender, DragAndDropEventArgs args)
    // {
    //     args.Allow = true;
    // }
    //
    // void Instance_DragAndDropStart(object sender, DragAndDropEventArgs args)
    // {
    //     //  The data should be a playing card.
    //     PlayingCardViewModel card = args.DragData as PlayingCardViewModel;
    //     if (card == null || card.IsPlayable == false)
    //     {
    //         args.Allow = false;
    //         return;
    //     }
    //     args.Allow = true;
    //
    //     //  If the card is draggable, we're going to want to drag the whole
    //     //  stack.
    //     IList<PlayingCardViewModel> cards = ViewModel.GetCardCollection(card);
    //     draggingCards = new List<PlayingCardViewModel>();
    //     int start = cards.IndexOf(card);
    //     for (int i = start; i < cards.Count; i++)
    //         draggingCards.Add(cards[i]);
    //
    //     //  Clear the drag stack.
    //     dragStack.Items = draggingCards;
    //     dragStack.UpdateLayout();
    //     args.DragAdorner = new Apex.Adorners.VisualAdorner(dragStack);
    //
    //     //  Hide each dragging card.
    //     ItemsControl sourceStack = args.DragSource as ItemsControl;
    //     foreach (var dragCard in draggingCards)
    //         ((ObservableCollection<PlayingCardViewModel>)sourceStack.Items).Remove(dragCard);
    // }
    //
    //
    // /// <summary>
    // /// The ViewModel dependency property.
    // /// </summary>
    // private static readonly DependencyProperty ViewModelProperty =
    //   DependencyProperty.Register("ViewModel", typeof(KlondikeSolitaireViewModel), typeof(KlondikeSolitaireView),
    //   new PropertyMetadata(new KlondikeSolitaireViewModel()));
    //
    // /// <summary>
    // /// Gets or sets the view model.
    // /// </summary>
    // /// <value>The view model.</value>
    // public KlondikeSolitaireViewModel ViewModel
    // {
    //     get { return (KlondikeSolitaireViewModel)GetValue(ViewModelProperty); }
    //     set { SetValue(ViewModelProperty, value); }
    // }
    //
    // /// <summary>
    // /// Handles the MouseRightButtonDown event of the dragAndDropHost control.
    // /// </summary>
    // /// <param name="sender">The source of the event.</param>
    // /// <param name="e">The <see cref="Avalonia.Input.MouseButtonEventArgs"/> instance containing the event data.</param>
    // private void dragAndDropHost_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
    // {
    //     ViewModel.TryMoveAllCardsToAppropriateFoundations();
    // }
    //
    // /// <summary>
    // /// Temporary storage for cards being dragged.
    // /// </summary>
    // private List<PlayingCardViewModel> draggingCards;
    //
    // /// <summary>
    // /// Handles the MouseLeftButtonUp event of the CardStackControl control.
    // /// </summary>
    // /// <param name="sender">The source of the event.</param>
    // /// <param name="e">The <see cref="Avalonia.Input.MouseButtonEventArgs"/> instance containing the event data.</param>
    // private void CardStackControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    // {
    //     ViewModel.TurnStockCommand.DoExecute(null);
    // }
}