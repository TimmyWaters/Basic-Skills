//
//  ViewController.swift
//  CheckList
//
//  Created by Timothy Waters on 7/13/18.
//  Copyright © 2018 Timothy Waters. All rights reserved.
//

import UIKit
import CoreData

//var listItems: [(item: NSMutableAttributedString, checked: Bool)] = []

class CheckListController: UITableViewController {
    
    let cellId = "cellId"
    var itemTextField: UITextField?
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        navigationItem.title = "CheckList"
        navigationItem.rightBarButtonItem = UIBarButtonItem(barButtonSystemItem: .add, target: self, action: #selector(addItem))
        tableView?.alwaysBounceVertical = true
        tableView.sectionHeaderHeight = 50
        tableView.separatorStyle = .none
    }
    
    override func viewWillAppear(_ animated: Bool) {
        super.viewWillAppear(animated)
    }
    
    override func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        let appDelegate = UIApplication.shared.delegate as? AppDelegate
        let managedContext = appDelegate?.persistentContainer.viewContext
        let fetchRequest: NSFetchRequest<ListItems> = ListItems.fetchRequest()
        fetchRequest.sortDescriptors = [NSSortDescriptor(key: "createdAt", ascending: true)]
        let fetchedResultsController = NSFetchedResultsController(fetchRequest: fetchRequest, managedObjectContext: managedContext!, sectionNameKeyPath: nil, cacheName: nil)
        fetchedResultsController.delegate = self as? NSFetchedResultsControllerDelegate
        do {
            try fetchedResultsController.performFetch()
        }
        catch {
            let fetchError = error as NSError
            print("Unable to Perform Fetch Request")
            print("\(fetchError), \(fetchError.localizedDescription)")
        }
        guard let listItems = fetchedResultsController.fetchedObjects else { return 0}
        return listItems.count
    }
    
    override func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        
        let cell = UITableViewCell(style: UITableViewCell.CellStyle.default, reuseIdentifier: "cellId")
        
        let appDelegate = UIApplication.shared.delegate as? AppDelegate
        let managedContext = appDelegate?.persistentContainer.viewContext
        let fetchRequest: NSFetchRequest<ListItems> = ListItems.fetchRequest()
        fetchRequest.sortDescriptors = [NSSortDescriptor(key: "createdAt", ascending: true)]
        let fetchedResultsController = NSFetchedResultsController(fetchRequest: fetchRequest, managedObjectContext: managedContext!, sectionNameKeyPath: nil, cacheName: nil)
        fetchedResultsController.delegate = self as? NSFetchedResultsControllerDelegate
        do {
            try fetchedResultsController.performFetch()
        }
        catch {
            let fetchError = error as NSError
            print("Unable to Perform Fetch Request")
            print("\(fetchError), \(fetchError.localizedDescription)")
        }
        
        let listItem = fetchedResultsController.object(at: indexPath)
        cell.textLabel?.text = listItem.itemString
//        cell.textLabel?.attributedText = listItems[indexPath.row].item
//
//        if listItems[indexPath.row].checked == true {
//            cell.accessoryType = .checkmark
//        }
        return cell
    }
    
    override func tableView(_ tableView: UITableView, commit editingStyle: UITableViewCell.EditingStyle, forRowAt indexPath: IndexPath) {
        if editingStyle == UITableViewCell.EditingStyle.delete {
            
            let appDelegate = UIApplication.shared.delegate as? AppDelegate
            let managedContext = appDelegate?.persistentContainer.viewContext
            let fetchRequest: NSFetchRequest<ListItems> = ListItems.fetchRequest()
            fetchRequest.sortDescriptors = [NSSortDescriptor(key: "createdAt", ascending: true)]
            let fetchedResultsController = NSFetchedResultsController(fetchRequest: fetchRequest, managedObjectContext: managedContext!, sectionNameKeyPath: nil, cacheName: nil)
            fetchedResultsController.delegate = self as? NSFetchedResultsControllerDelegate
            do {
                try fetchedResultsController.performFetch()
            }
            catch {
                let fetchError = error as NSError
                print("Unable to Perform Fetch Request")
                print("\(fetchError), \(fetchError.localizedDescription)")
            }
            let listItem = fetchedResultsController.object(at: indexPath)
            listItem.managedObjectContext?.delete(listItem)
            
            do {
                try managedContext?.save()
            }
            catch {
                print("Unable to Save Changes")
                print("\(error), \(error.localizedDescription)")
            }
            tableView.reloadData()
        }
    }
    
    func controller(_ controller: NSFetchedResultsController<NSFetchRequestResult>, didChange anObject: Any, at indexPath: IndexPath?, for type: NSFetchedResultsChangeType, newIndexPath: IndexPath?) {
        switch (type) {
        case .insert:
            if let indexPath = newIndexPath {
                tableView.insertRows(at: [indexPath], with: .fade)
            }
            break;
        case .delete:
            if let indexPath = indexPath {
                tableView.deleteRows(at: [indexPath], with: .fade)
            }
            break;
        default:
            print("...")
        }
    }
    
    override func tableView(_ tableView: UITableView, didSelectRowAt indexPath: IndexPath) {
        
//        var tempItem = listItems[indexPath.row]
//        let attrString = listItems[indexPath.row].item
//
//        switch listItems[indexPath.row].checked {
//        case false:
//            tableView.cellForRow(at: indexPath)?.accessoryType = UITableViewCell.AccessoryType.checkmark
//            attrString.addAttribute(NSAttributedString.Key.strikethroughStyle, value: 2, range: NSMakeRange(0, attrString.length))
//            tableView.cellForRow(at: indexPath)?.textLabel?.attributedText = attrString
//            listItems[indexPath.row].checked = true
//            tempItem = listItems[indexPath.row]
//            listItems.remove(at: indexPath.row)
//            listItems.append(tempItem)
//
//        case true:
//            tableView.cellForRow(at: indexPath)?.accessoryType = UITableViewCell.AccessoryType.none
//            attrString.removeAttribute(NSAttributedString.Key.strikethroughStyle, range: NSMakeRange(0, attrString.length))
//            tableView.cellForRow(at: indexPath)?.textLabel?.attributedText = attrString
//            listItems[indexPath.row].checked = false
//            tempItem = listItems[indexPath.row]
//            listItems.remove(at: indexPath.row)
//            listItems.insert(tempItem, at: 0)
//        }
//
        tableView.reloadData()
    }
    
    override func viewDidAppear(_ animated: Bool) {
        tableView.reloadData()
    }
    
    @objc func addItem(_ sender: Any) {
        let alertController = UIAlertController(title: "Add an item to your list", message: nil, preferredStyle: .alert)
        alertController.addTextField(configurationHandler: itemTextField)
        
        let okAction = UIAlertAction(title: "OK", style: .default, handler: self.okHandler)
        let cancelAction = UIAlertAction(title: "Cancel", style: .cancel, handler: nil)
        alertController.addAction(okAction)
        alertController.addAction(cancelAction)
        self.present(alertController, animated: true)
    }
    
    func itemTextField(textfield: UITextField!) {
        itemTextField = textfield
        itemTextField?.autocapitalizationType = .sentences
        itemTextField?.placeholder = "CheckList Item"
    }
    
    func okHandler(alert: UIAlertAction) {
        guard let appDelegate = UIApplication.shared.delegate as? AppDelegate else {return}
        let managedContext = appDelegate.persistentContainer.viewContext
        
        let listItem = ListItems(context: managedContext)
        
        if itemTextField?.text != nil {
            listItem.itemString = itemTextField?.text
            listItem.isChecked = false
            listItem.createdAt = Date().timeIntervalSince1970
            
            do {
                try managedContext.save()
            }
            catch {
                print("Unable to Save Changes")
                print("\(error), \(error.localizedDescription)")
            }
            
            tableView.reloadData()
        }
    }
}

