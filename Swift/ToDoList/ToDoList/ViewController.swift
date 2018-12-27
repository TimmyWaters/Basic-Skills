//
//  ViewController.swift
//  ToDoList
//
//  Created by Timothy Waters on 10/15/17.
//  Copyright © 2017 Timothy Waters. All rights reserved.
//

import UIKit
import CoreData

var list: [(item: NSMutableAttributedString, checked: Bool)] = []

class ViewController: UIViewController, UITableViewDelegate, UITableViewDataSource {
    
    var itemTextField: UITextField?
    
    @IBOutlet weak var myTableView: UITableView!
    
    public func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        return(list.count)
    }
    
    public func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        let cell = UITableViewCell(style: UITableViewCell.CellStyle.default, reuseIdentifier: "cell")
        cell.textLabel?.attributedText = list[indexPath.row].item
        if list[indexPath.row].checked == true {
            cell.accessoryType = .checkmark
        }
       
        return(cell)
    }
    
    func tableView(_ tableView: UITableView, commit editingStyle: UITableViewCell.EditingStyle, forRowAt indexPath: IndexPath)
    {
        if editingStyle == UITableViewCell.EditingStyle.delete
        {
            list.remove(at: indexPath.row)
            myTableView.reloadData()
        }
    }
    
    func tableView(_ tableView: UITableView, didSelectRowAt indexPath: IndexPath) {
        
        var tempItem = list[indexPath.row]
        let attrString = list[indexPath.row].item
        switch list[indexPath.row].checked {
        case false:
            tableView.cellForRow(at: indexPath)?.accessoryType = UITableViewCell.AccessoryType.checkmark
            attrString.addAttribute(NSAttributedString.Key.strikethroughStyle, value: 2, range: NSMakeRange(0, attrString.length))
            tableView.cellForRow(at: indexPath)?.textLabel?.attributedText = attrString
            list[indexPath.row].checked = true
            tempItem = list[indexPath.row]
            list.remove(at: indexPath.row)
            list.append(tempItem)
        case true:
            tableView.cellForRow(at: indexPath)?.accessoryType = UITableViewCell.AccessoryType.none
            attrString.removeAttribute(NSAttributedString.Key.strikethroughStyle, range: NSMakeRange(0, attrString.length))
            tableView.cellForRow(at: indexPath)?.textLabel?.attributedText = attrString
            list[indexPath.row].checked = false
            tempItem = list[indexPath.row]
            list.remove(at: indexPath.row)
            list.insert(tempItem, at: 0)
        }
        myTableView.reloadData()
    }
    
    override func viewDidAppear(_ animated: Bool) {
        myTableView.reloadData()
    }
    
    override func viewDidLoad() {
        super.viewDidLoad()
    }
    
    @IBAction func addItem(_ sender: Any) {
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
        itemTextField?.placeholder = "To-Do Item"
    }
    
    func okHandler(alert: UIAlertAction) {
        if itemTextField?.text != nil {
            list.append((item: NSMutableAttributedString(string: (itemTextField?.text)!), checked: false))
            myTableView.reloadData()
        }
    }
    
}

